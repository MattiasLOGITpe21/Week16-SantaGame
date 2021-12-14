namespace ChristmasGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground = new System.Windows.Forms.PictureBox();
            this.santa = new System.Windows.Forms.PictureBox();
            this.snowflake = new System.Windows.Forms.PictureBox();
            this.snowflake1 = new System.Windows.Forms.PictureBox();
            this.treeBottom = new System.Windows.Forms.PictureBox();
            this.treeTop = new System.Windows.Forms.PictureBox();
            this.hut = new System.Windows.Forms.PictureBox();
            this.moon = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 889);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1231, 118);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // santa
            // 
            this.santa.Image = ((System.Drawing.Image)(resources.GetObject("santa.Image")));
            this.santa.Location = new System.Drawing.Point(145, 343);
            this.santa.Name = "santa";
            this.santa.Size = new System.Drawing.Size(286, 149);
            this.santa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.santa.TabIndex = 1;
            this.santa.TabStop = false;
            this.santa.Click += new System.EventHandler(this.santa_Click);
            // 
            // snowflake
            // 
            this.snowflake.Image = ((System.Drawing.Image)(resources.GetObject("snowflake.Image")));
            this.snowflake.Location = new System.Drawing.Point(117, 487);
            this.snowflake.Name = "snowflake";
            this.snowflake.Size = new System.Drawing.Size(42, 43);
            this.snowflake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake.TabIndex = 2;
            this.snowflake.TabStop = false;
            // 
            // snowflake1
            // 
            this.snowflake1.Image = ((System.Drawing.Image)(resources.GetObject("snowflake1.Image")));
            this.snowflake1.Location = new System.Drawing.Point(92, 525);
            this.snowflake1.Name = "snowflake1";
            this.snowflake1.Size = new System.Drawing.Size(29, 24);
            this.snowflake1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snowflake1.TabIndex = 3;
            this.snowflake1.TabStop = false;
            // 
            // treeBottom
            // 
            this.treeBottom.Image = ((System.Drawing.Image)(resources.GetObject("treeBottom.Image")));
            this.treeBottom.Location = new System.Drawing.Point(621, 610);
            this.treeBottom.Name = "treeBottom";
            this.treeBottom.Size = new System.Drawing.Size(152, 277);
            this.treeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treeBottom.TabIndex = 4;
            this.treeBottom.TabStop = false;
            // 
            // treeTop
            // 
            this.treeTop.Image = ((System.Drawing.Image)(resources.GetObject("treeTop.Image")));
            this.treeTop.Location = new System.Drawing.Point(609, 4);
            this.treeTop.Name = "treeTop";
            this.treeTop.Size = new System.Drawing.Size(163, 254);
            this.treeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treeTop.TabIndex = 5;
            this.treeTop.TabStop = false;
            // 
            // hut
            // 
            this.hut.Image = ((System.Drawing.Image)(resources.GetObject("hut.Image")));
            this.hut.Location = new System.Drawing.Point(985, 692);
            this.hut.Name = "hut";
            this.hut.Size = new System.Drawing.Size(206, 197);
            this.hut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hut.TabIndex = 6;
            this.hut.TabStop = false;
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(217, 4);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(332, 131);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 7;
            this.moon.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(0, 58);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(166, 49);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "score : 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.Location = new System.Drawing.Point(572, 365);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(254, 164);
            this.button.TabIndex = 9;
            this.button.Text = "PLAY AGAIN?";
            this.button.UseVisualStyleBackColor = true;
            this.button.Visible = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1218, 1003);
            this.Controls.Add(this.button);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.hut);
            this.Controls.Add(this.treeTop);
            this.Controls.Add(this.treeBottom);
            this.Controls.Add(this.snowflake1);
            this.Controls.Add(this.snowflake);
            this.Controls.Add(this.santa);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snowflake1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox santa;
        private System.Windows.Forms.PictureBox snowflake;
        private System.Windows.Forms.PictureBox snowflake1;
        private System.Windows.Forms.PictureBox treeBottom;
        private System.Windows.Forms.PictureBox treeTop;
        private System.Windows.Forms.PictureBox hut;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button;
    }
}

