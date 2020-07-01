using Punch_Out.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch_Out
{
    public class Scene
    {
        private Player Player;
        private Enemy Enemy;
        private SoundPlayer bellPlayer;
        private SoundPlayer crowdPlayer;
        private Point ringTopLeft;
        private Point ringTopRight;
        private Point ringBottomLeft;
        private Point ringBottomRight;
       // private int RoundNum;

        public Scene(Point middlePoint)
        {
           // this.RoundNum = 1;

            this.Enemy = new Enemy(middlePoint, Resources.idle);
            this.Player = new Player(middlePoint, Resources.mac_idle);

            this.Enemy.SetEnemy(this.Player);
            this.Player.SetEnemy(this.Enemy);

            this.bellPlayer = new SoundPlayer(Resources.bell);
            this.bellPlayer.PlaySync();

            this.crowdPlayer = new SoundPlayer(Resources.Crowd);
            this.crowdPlayer.PlayLooping();

            this.ringTopLeft = new Point(134, 320);
            this.ringTopRight = new Point(1014, 320);
            this.ringBottomLeft = new Point(70, 469);
            this.ringBottomRight = new Point(1078, 469);

        }

        public void Draw(Graphics g)
        {
            this.Enemy.Draw(g);
            this.Player.Draw(g);

        }

       /* public int GetRoundNumber()
        {
            return this.RoundNum;
        }*/
        public void movePlayer(Keys key)
        {
            switch(key)
            {
                case Keys.Up:
                    Player.MoveUp();
                    break;
                case Keys.Down:
                    Player.MoveDown();
                    break;
                case Keys.Left:
                    if (isRight(ringTopLeft, ringBottomLeft, new Point(Player.GetPosition().X, Player.GetPosition().Y + Player.GetHeight())))
                    Player.MoveLeft();
                    break;
                case Keys.Right:
                    if (isLeft(ringTopRight, ringBottomRight, new Point(Player.GetPosition().X + Player.GetWidth(), Player.GetPosition().Y + Player.GetHeight())))
                        Player.MoveRight();
                    break;
            }
        }

        public void changePlayerState(char KeyChar)
        {
            switch(KeyChar)
            {
            case 's':
                    Player.Block();
                break;
                case 'a':
                    Player.Punch(true);
                break;
                case 'd':
                    Player.Punch(false);
                break;
                //DEFAULT TO BE DELETED OR NOT?
                default:
                    Player.Idle();
                break;
            }
        }

        public void moveEnemy(int direction)
        {
            switch(direction)
            {
                case 1:
                    this.Enemy.MoveUp();
                    break;
                case 2:
                    this.Enemy.MoveDown();
                    break;
                case 3:
                    if (isRight(ringTopLeft, ringBottomLeft, new Point(Enemy.GetPosition().X, Enemy.GetPosition().Y + Enemy.GetHeight())))
                        this.Enemy.MoveLeft();
                    break;
                case 4:
                    if (isLeft(ringTopRight, ringBottomRight, new Point(Enemy.GetPosition().X + Enemy.GetWidth(), Player.GetPosition().Y + Enemy.GetHeight())))
                        this.Enemy.MoveRight();
                    break;
            }
        }

        public void changeEnemyState(Boxer.STATE STATE)
        {
            switch (STATE)
            {
                case Boxer.STATE.IDLE:
                    this.Enemy.Idle();
                    break;

                case Boxer.STATE.BLOCK:
                    this.Enemy.Block();
                    break;

                case Boxer.STATE.LEFT:
                    this.Enemy.Punch(true);
                    break;

                case Boxer.STATE.RIGHT:
                    this.Enemy.Punch(false);
                    break;
            }
        }
        private bool isLeft(Point P1, Point P2, Point T)
        {
            return ((P2.X - P1.X) * (T.Y - P1.Y) - (P2.Y - P1.Y) * (T.X - P1.X) > 0);
        }

        private bool isRight(Point P1, Point P2, Point T)
        {
            return !this.isLeft(P1, P2, T);
        }

        public int GetPlayerHealth()
        {
            return this.Player.GetHealth();
        }

        public int GetEnemyHealth()
        {
            return this.Enemy.GetHealth();
        }

        public void StopAudio()
        {
            this.bellPlayer.Stop();
            this.crowdPlayer.Stop();
        }
        public bool IsRoundOver()
        {
            return this.Enemy.isDead() || this.Player.isDead();
        }
        public void End()
        {
            this.bellPlayer.Stream = Resources.bell_end;
            this.bellPlayer.PlaySync();
            this.crowdPlayer.Stop();
        }

        public bool win()
        {
            return this.Enemy.isDead();
        }

    }
}
