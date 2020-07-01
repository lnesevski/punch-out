namespace Punch_Out
{
    partial class HomeForm
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
            this.playButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlsButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.closeControlsButton = new System.Windows.Forms.Button();
            this.controlsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(458, 234);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(203, 63);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Punch_Out.Properties.Resources.punchOut;
            this.pictureBox1.Location = new System.Drawing.Point(134, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 207);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // controlsButton
            // 
            this.controlsButton.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlsButton.Location = new System.Drawing.Point(458, 327);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(203, 63);
            this.controlsButton.TabIndex = 2;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = true;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(458, 428);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(203, 63);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // closeControlsButton
            // 
            this.closeControlsButton.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeControlsButton.Location = new System.Drawing.Point(458, 484);
            this.closeControlsButton.Name = "closeControlsButton";
            this.closeControlsButton.Size = new System.Drawing.Size(203, 63);
            this.closeControlsButton.TabIndex = 4;
            this.closeControlsButton.Text = "Back";
            this.closeControlsButton.UseVisualStyleBackColor = true;
            this.closeControlsButton.Click += new System.EventHandler(this.closeControlsButton_Click);
            // 
            // controlsPictureBox
            // 
            this.controlsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.controlsPictureBox.Image = global::Punch_Out.Properties.Resources.controls;
            this.controlsPictureBox.Location = new System.Drawing.Point(96, -15);
            this.controlsPictureBox.Name = "controlsPictureBox";
            this.controlsPictureBox.Size = new System.Drawing.Size(917, 466);
            this.controlsPictureBox.TabIndex = 5;
            this.controlsPictureBox.TabStop = false;
            this.controlsPictureBox.Visible = false;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Punch_Out.Properties.Resources.homeBackground;
            this.ClientSize = new System.Drawing.Size(1106, 571);
            this.Controls.Add(this.closeControlsButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.controlsButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.controlsPictureBox);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button controlsButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button closeControlsButton;
        private System.Windows.Forms.PictureBox controlsPictureBox;
    }
}