using Punch_Out.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch_Out
{
    public partial class HomeForm : Form
    {
        private Form1 game;
        public HomeForm()
        {
            InitializeComponent();
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
            this.pictureBox1.BackColor = Color.Transparent;
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);
            this.pictureBox1.Size = new Size(Resources.punchOut.Width, Resources.punchOut.Height);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.closeControlsButton.Hide();   
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            this.game = new Form1(this);
            
            this.Hide();

            game.Show();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Hide();
            this.playButton.Hide();
            this.quitButton.Hide();
            this.controlsButton.Hide();
            this.controlsPictureBox.Show();
            this.closeControlsButton.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeControlsButton_Click(object sender, EventArgs e)
        {
            this.controlsPictureBox.Hide();
            this.pictureBox1.Show();
            this.closeControlsButton.Hide();
            this.playButton.Show();
            this.controlsButton.Show();
            this.quitButton.Show();

        }
    }
}
