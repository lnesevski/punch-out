using Punch_Out.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch_Out
{
    public partial class Form1 : Form
    {
        private int backgroundNum;
        private Scene Scene;
        private HomeForm Home;
        private Point midPoint;
        private Random enemyMovementGenerator;
        private Random enemyStateGenerator;
        private int CurrentRound;
        private int PlayerWins;
        private int EnemyWins;
       
        public Form1(HomeForm ParentForm)
        {
            InitializeComponent();
            this.backgroundNum = 1;
            this.DoubleBuffered = true;

            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

            this.midPoint = new Point((int)this.Width / 2,(int)this.Height / 2);
            this.Scene = new Scene(midPoint);

            this.enemyMovementGenerator = new Random();
            this.enemyStateGenerator = new Random();

            this.PlayerHealthBar();
            this.EnemyHealthBar();

            this.Home = ParentForm;

            this.CurrentRound = 1;

            this.PlayerWins = 0;
            this.EnemyWins = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.playerIcon.Image = Resources.mac_icon;
            this.enemyIcon.Image = Resources.enemy_icon;
            this.roundNum.Text = String.Format(" Round {0}", this.CurrentRound);
        }

        private void backgroundAnimationTimer_Tick(object sender, EventArgs e)
        {
            switch(this.backgroundNum)
            {
                case 1:
                    this.BackgroundImage = Resources.ringA;
                    this.backgroundNum++;
                    break;
                case 2:
                    this.BackgroundImage = Resources.ringB;
                    this.backgroundNum++;
                    break;
                case 3:
                    this.BackgroundImage = Resources.ringC;
                    this.backgroundNum++;
                    break;
                case 4:
                    this.BackgroundImage = Resources.ringD;
                    this.backgroundNum = 1;
                    break;
               
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Scene.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                this.Scene.movePlayer(e.KeyCode);
                Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Scene.changePlayerState('w');
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Scene.changePlayerState(e.KeyChar);
            EnemyHealthBar();
            if(this.Scene.IsRoundOver())
            {
                this.enemyMovementTimer.Stop();
                this.enemyStateTimer.Stop();
                this.Scene.End();
                String text = Scene.win() ? "You win!" : "You lose.";
                if (Scene.win())
                {
                    this.PlayerWins++;
                }
                else
                {
                    this.EnemyWins++;
                }
                if (DialogResult.Yes == MessageBox.Show("Play again?", text, MessageBoxButtons.YesNo))
                {

                    this.Scene = new Scene(this.midPoint);
                    this.PlayerHealthBar();
                    this.EnemyHealthBar();
                    this.roundNum.Text = String.Format("Round {0}", ++this.CurrentRound);
                    this.enemyMovementTimer.Start();
                    this.enemyStateTimer.Start();
                    this.playerWinsLabel.Text = String.Format("{0}", this.PlayerWins);
                    this.enemyWinsLabel.Text = String.Format("{0}", this.EnemyWins);

                }
                else
                {
                   this.Home.Show();
                    this.Close();
                }
            }
        }

        private void PlayerHealthBar()
        {
            this.playerHealth.Value = this.Scene.GetPlayerHealth();
        }

        private void EnemyHealthBar()
        {
            this.enemyHealth.Value = Scene.GetEnemyHealth();
        }

        private void enemyMovementTimer_Tick(object sender, EventArgs e)
        {
            int direction = this.enemyMovementGenerator.Next(1, 5);
            Scene.moveEnemy(direction);
        }

        private void enemyStateTimer_Tick(object sender, EventArgs e)
        {
            int state = this.enemyStateGenerator.Next(1, 101);
            if (state <= 30)
            {
                Scene.changeEnemyState(Boxer.STATE.IDLE);
            }
            else if (state <= 70)
            {
                Scene.changeEnemyState(Boxer.STATE.BLOCK);
            }
            else if (state <= 85)
            {
                Scene.changeEnemyState(Boxer.STATE.LEFT);
                this.PlayerHealthBar();
            }
            else
            {
                Scene.changeEnemyState(Boxer.STATE.RIGHT);
                this.PlayerHealthBar();
            }
            
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Home.Show();
            this.Scene.StopAudio();
        }

    }
}
