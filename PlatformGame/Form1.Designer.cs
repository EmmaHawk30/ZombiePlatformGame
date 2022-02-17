namespace PlatformGame
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
            this.platformBottom = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.platform1 = new System.Windows.Forms.PictureBox();
            this.platform2 = new System.Windows.Forms.PictureBox();
            this.platform3 = new System.Windows.Forms.PictureBox();
            this.platform4 = new System.Windows.Forms.PictureBox();
            this.platform5 = new System.Windows.Forms.PictureBox();
            this.platform6 = new System.Windows.Forms.PictureBox();
            this.door = new System.Windows.Forms.PictureBox();
            this.brain3 = new System.Windows.Forms.PictureBox();
            this.brain2 = new System.Windows.Forms.PictureBox();
            this.brain4 = new System.Windows.Forms.PictureBox();
            this.brain1 = new System.Windows.Forms.PictureBox();
            this.brain5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.platformBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain5)).BeginInit();
            this.SuspendLayout();
            // 
            // platformBottom
            // 
            this.platformBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platformBottom.Image = ((System.Drawing.Image)(resources.GetObject("platformBottom.Image")));
            this.platformBottom.Location = new System.Drawing.Point(-1, 361);
            this.platformBottom.Margin = new System.Windows.Forms.Padding(2);
            this.platformBottom.Name = "platformBottom";
            this.platformBottom.Size = new System.Drawing.Size(319, 23);
            this.platformBottom.TabIndex = 0;
            this.platformBottom.TabStop = false;
            this.platformBottom.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(253, 328);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(20, 32);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // platform1
            // 
            this.platform1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform1.Image = ((System.Drawing.Image)(resources.GetObject("platform1.Image")));
            this.platform1.Location = new System.Drawing.Point(22, 298);
            this.platform1.Margin = new System.Windows.Forms.Padding(2);
            this.platform1.Name = "platform1";
            this.platform1.Size = new System.Drawing.Size(100, 20);
            this.platform1.TabIndex = 2;
            this.platform1.TabStop = false;
            this.platform1.Tag = "platform";
            // 
            // platform2
            // 
            this.platform2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform2.Image = ((System.Drawing.Image)(resources.GetObject("platform2.Image")));
            this.platform2.Location = new System.Drawing.Point(178, 242);
            this.platform2.Margin = new System.Windows.Forms.Padding(2);
            this.platform2.Name = "platform2";
            this.platform2.Size = new System.Drawing.Size(133, 23);
            this.platform2.TabIndex = 3;
            this.platform2.TabStop = false;
            this.platform2.Tag = "platform";
            // 
            // platform3
            // 
            this.platform3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform3.Image = ((System.Drawing.Image)(resources.GetObject("platform3.Image")));
            this.platform3.Location = new System.Drawing.Point(78, 182);
            this.platform3.Margin = new System.Windows.Forms.Padding(2);
            this.platform3.Name = "platform3";
            this.platform3.Size = new System.Drawing.Size(74, 19);
            this.platform3.TabIndex = 4;
            this.platform3.TabStop = false;
            this.platform3.Tag = "platform";
            // 
            // platform4
            // 
            this.platform4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform4.Image = ((System.Drawing.Image)(resources.GetObject("platform4.Image")));
            this.platform4.Location = new System.Drawing.Point(22, 131);
            this.platform4.Margin = new System.Windows.Forms.Padding(2);
            this.platform4.Name = "platform4";
            this.platform4.Size = new System.Drawing.Size(80, 23);
            this.platform4.TabIndex = 5;
            this.platform4.TabStop = false;
            this.platform4.Tag = "platform";
            // 
            // platform5
            // 
            this.platform5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform5.Image = ((System.Drawing.Image)(resources.GetObject("platform5.Image")));
            this.platform5.Location = new System.Drawing.Point(178, 112);
            this.platform5.Margin = new System.Windows.Forms.Padding(2);
            this.platform5.Name = "platform5";
            this.platform5.Size = new System.Drawing.Size(125, 23);
            this.platform5.TabIndex = 6;
            this.platform5.TabStop = false;
            this.platform5.Tag = "platform";
            // 
            // platform6
            // 
            this.platform6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform6.Image = ((System.Drawing.Image)(resources.GetObject("platform6.Image")));
            this.platform6.Location = new System.Drawing.Point(22, 49);
            this.platform6.Margin = new System.Windows.Forms.Padding(2);
            this.platform6.Name = "platform6";
            this.platform6.Size = new System.Drawing.Size(115, 23);
            this.platform6.TabIndex = 7;
            this.platform6.TabStop = false;
            this.platform6.Tag = "platform";
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door.Image = ((System.Drawing.Image)(resources.GetObject("door.Image")));
            this.door.Location = new System.Drawing.Point(22, 8);
            this.door.Margin = new System.Windows.Forms.Padding(2);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(25, 42);
            this.door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door.TabIndex = 8;
            this.door.TabStop = false;
            this.door.Tag = "";
            // 
            // brain3
            // 
            this.brain3.BackColor = System.Drawing.Color.Transparent;
            this.brain3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brain3.BackgroundImage")));
            this.brain3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brain3.Location = new System.Drawing.Point(266, 211);
            this.brain3.Margin = new System.Windows.Forms.Padding(2);
            this.brain3.Name = "brain3";
            this.brain3.Size = new System.Drawing.Size(13, 13);
            this.brain3.TabIndex = 9;
            this.brain3.TabStop = false;
            this.brain3.Tag = "brain";
            // 
            // brain2
            // 
            this.brain2.BackColor = System.Drawing.Color.Transparent;
            this.brain2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brain2.BackgroundImage")));
            this.brain2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brain2.Location = new System.Drawing.Point(15, 252);
            this.brain2.Margin = new System.Windows.Forms.Padding(2);
            this.brain2.Name = "brain2";
            this.brain2.Size = new System.Drawing.Size(13, 13);
            this.brain2.TabIndex = 10;
            this.brain2.TabStop = false;
            this.brain2.Tag = "brain";
            // 
            // brain4
            // 
            this.brain4.BackColor = System.Drawing.Color.Transparent;
            this.brain4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brain4.BackgroundImage")));
            this.brain4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brain4.Location = new System.Drawing.Point(123, 141);
            this.brain4.Margin = new System.Windows.Forms.Padding(2);
            this.brain4.Name = "brain4";
            this.brain4.Size = new System.Drawing.Size(13, 13);
            this.brain4.TabIndex = 11;
            this.brain4.TabStop = false;
            this.brain4.Tag = "brain";
            // 
            // brain1
            // 
            this.brain1.BackColor = System.Drawing.Color.Transparent;
            this.brain1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brain1.BackgroundImage")));
            this.brain1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brain1.Location = new System.Drawing.Point(101, 334);
            this.brain1.Margin = new System.Windows.Forms.Padding(2);
            this.brain1.Name = "brain1";
            this.brain1.Size = new System.Drawing.Size(13, 13);
            this.brain1.TabIndex = 12;
            this.brain1.TabStop = false;
            this.brain1.Tag = "brain";
            // 
            // brain5
            // 
            this.brain5.BackColor = System.Drawing.Color.Transparent;
            this.brain5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brain5.BackgroundImage")));
            this.brain5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brain5.Location = new System.Drawing.Point(297, 19);
            this.brain5.Margin = new System.Windows.Forms.Padding(2);
            this.brain5.Name = "brain5";
            this.brain5.Size = new System.Drawing.Size(13, 13);
            this.brain5.TabIndex = 13;
            this.brain5.TabStop = false;
            this.brain5.Tag = "brain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 386);
            this.Controls.Add(this.brain5);
            this.Controls.Add(this.brain1);
            this.Controls.Add(this.brain4);
            this.Controls.Add(this.brain2);
            this.Controls.Add(this.brain3);
            this.Controls.Add(this.door);
            this.Controls.Add(this.platform6);
            this.Controls.Add(this.platform5);
            this.Controls.Add(this.platform4);
            this.Controls.Add(this.platform3);
            this.Controls.Add(this.platform2);
            this.Controls.Add(this.platform1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platformBottom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Platform Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.platformBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brain5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox platformBottom;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox platform1;
        private System.Windows.Forms.PictureBox platform2;
        private System.Windows.Forms.PictureBox platform3;
        private System.Windows.Forms.PictureBox platform4;
        private System.Windows.Forms.PictureBox platform5;
        private System.Windows.Forms.PictureBox platform6;
        private System.Windows.Forms.PictureBox door;
        private System.Windows.Forms.PictureBox brain3;
        private System.Windows.Forms.PictureBox brain2;
        private System.Windows.Forms.PictureBox brain4;
        private System.Windows.Forms.PictureBox brain1;
        private System.Windows.Forms.PictureBox brain5;
    }
}

