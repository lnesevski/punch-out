namespace Punch_Out
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.playerHealth = new System.Windows.Forms.ProgressBar();
            this.enemyHealth = new System.Windows.Forms.ProgressBar();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.enemyIcon = new System.Windows.Forms.PictureBox();
            this.roundNum = new System.Windows.Forms.Label();
            this.enemyMovementTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyStateTimer = new System.Windows.Forms.Timer(this.components);
            this.playerWinsLabel = new System.Windows.Forms.Label();
            this.enemyWinsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundAnimationTimer
            // 
            this.backgroundAnimationTimer.Enabled = true;
            this.backgroundAnimationTimer.Interval = 500;
            this.backgroundAnimationTimer.Tick += new System.EventHandler(this.backgroundAnimationTimer_Tick);
            // 
            // playerHealth
            // 
            this.playerHealth.Location = new System.Drawing.Point(94, 12);
            this.playerHealth.Name = "playerHealth";
            this.playerHealth.Size = new System.Drawing.Size(270, 20);
            this.playerHealth.TabIndex = 0;
            this.playerHealth.Value = 100;
            // 
            // enemyHealth
            // 
            this.enemyHealth.Location = new System.Drawing.Point(768, 12);
            this.enemyHealth.Name = "enemyHealth";
            this.enemyHealth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enemyHealth.RightToLeftLayout = true;
            this.enemyHealth.Size = new System.Drawing.Size(270, 20);
            this.enemyHealth.TabIndex = 2;
            this.enemyHealth.Value = 100;
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = System.Drawing.Color.White;
            this.playerIcon.Image = global::Punch_Out.Properties.Resources.mac_icon;
            this.playerIcon.Location = new System.Drawing.Point(12, 12);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(76, 70);
            this.playerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerIcon.TabIndex = 3;
            this.playerIcon.TabStop = false;
            // 
            // enemyIcon
            // 
            this.enemyIcon.BackColor = System.Drawing.Color.White;
            this.enemyIcon.Image = global::Punch_Out.Properties.Resources.enemy_icon;
            this.enemyIcon.Location = new System.Drawing.Point(1044, 12);
            this.enemyIcon.Name = "enemyIcon";
            this.enemyIcon.Size = new System.Drawing.Size(76, 70);
            this.enemyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyIcon.TabIndex = 4;
            this.enemyIcon.TabStop = false;
            this.enemyIcon.WaitOnLoad = true;
            // 
            // roundNum
            // 
            this.roundNum.AutoSize = true;
            this.roundNum.BackColor = System.Drawing.Color.Transparent;
            this.roundNum.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundNum.ForeColor = System.Drawing.Color.White;
            this.roundNum.Location = new System.Drawing.Point(525, 12);
            this.roundNum.Name = "roundNum";
            this.roundNum.Size = new System.Drawing.Size(89, 24);
            this.roundNum.TabIndex = 5;
            this.roundNum.Text = "Round 0";
            // 
            // enemyMovementTimer
            // 
            this.enemyMovementTimer.Enabled = true;
            this.enemyMovementTimer.Interval = 200;
            this.enemyMovementTimer.Tick += new System.EventHandler(this.enemyMovementTimer_Tick);
            // 
            // enemyStateTimer
            // 
            this.enemyStateTimer.Enabled = true;
            this.enemyStateTimer.Interval = 400;
            this.enemyStateTimer.Tick += new System.EventHandler(this.enemyStateTimer_Tick);
            // 
            // playerWinsLabel
            // 
            this.playerWinsLabel.AutoSize = true;
            this.playerWinsLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerWinsLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerWinsLabel.ForeColor = System.Drawing.Color.White;
            this.playerWinsLabel.Location = new System.Drawing.Point(370, 12);
            this.playerWinsLabel.Name = "playerWinsLabel";
            this.playerWinsLabel.Size = new System.Drawing.Size(21, 24);
            this.playerWinsLabel.TabIndex = 6;
            this.playerWinsLabel.Text = "0";
            // 
            // enemyWinsLabel
            // 
            this.enemyWinsLabel.AutoSize = true;
            this.enemyWinsLabel.BackColor = System.Drawing.Color.Transparent;
            this.enemyWinsLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyWinsLabel.ForeColor = System.Drawing.Color.White;
            this.enemyWinsLabel.Location = new System.Drawing.Point(741, 12);
            this.enemyWinsLabel.Name = "enemyWinsLabel";
            this.enemyWinsLabel.Size = new System.Drawing.Size(21, 24);
            this.enemyWinsLabel.TabIndex = 7;
            this.enemyWinsLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1132, 469);
            this.Controls.Add(this.enemyWinsLabel);
            this.Controls.Add(this.playerWinsLabel);
            this.Controls.Add(this.roundNum);
            this.Controls.Add(this.enemyIcon);
            this.Controls.Add(this.playerIcon);
            this.Controls.Add(this.enemyHealth);
            this.Controls.Add(this.playerHealth);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer backgroundAnimationTimer;
        private System.Windows.Forms.ProgressBar playerHealth;
        private System.Windows.Forms.ProgressBar enemyHealth;
        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.PictureBox enemyIcon;
        private System.Windows.Forms.Label roundNum;
        private System.Windows.Forms.Timer enemyMovementTimer;
        private System.Windows.Forms.Timer enemyStateTimer;
        private System.Windows.Forms.Label playerWinsLabel;
        private System.Windows.Forms.Label enemyWinsLabel;
    }
}

