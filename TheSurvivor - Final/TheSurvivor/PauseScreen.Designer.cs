namespace TheSurvivor
{
    partial class PauseScreen
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
            this.mainMenu = new System.Windows.Forms.Button();
            this.returnToGame = new System.Windows.Forms.Button();
            this.keyBox = new System.Windows.Forms.GroupBox();
            this.arrowsBox = new System.Windows.Forms.PictureBox();
            this.wasdBtn = new System.Windows.Forms.RadioButton();
            this.arrowBtn = new System.Windows.Forms.RadioButton();
            this.wasdBox = new System.Windows.Forms.PictureBox();
            this.soundBox = new System.Windows.Forms.GroupBox();
            this.onBox = new System.Windows.Forms.PictureBox();
            this.offBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.offBtn = new System.Windows.Forms.RadioButton();
            this.onBtn = new System.Windows.Forms.RadioButton();
            this.keyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wasdBox)).BeginInit();
            this.soundBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Silver;
            this.mainMenu.BackgroundImage = global::TheSurvivor.Properties.Resources.mainMenu1;
            this.mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mainMenu.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ForeColor = System.Drawing.Color.Green;
            this.mainMenu.Location = new System.Drawing.Point(51, 285);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(194, 47);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // returnToGame
            // 
            this.returnToGame.BackColor = System.Drawing.Color.White;
            this.returnToGame.BackgroundImage = global::TheSurvivor.Properties.Resources.returnToGame1;
            this.returnToGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnToGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnToGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnToGame.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToGame.ForeColor = System.Drawing.Color.Green;
            this.returnToGame.Location = new System.Drawing.Point(270, 285);
            this.returnToGame.Name = "returnToGame";
            this.returnToGame.Size = new System.Drawing.Size(194, 47);
            this.returnToGame.TabIndex = 3;
            this.returnToGame.UseVisualStyleBackColor = false;
            this.returnToGame.Click += new System.EventHandler(this.returnToGame_Click);
            // 
            // keyBox
            // 
            this.keyBox.BackColor = System.Drawing.Color.Transparent;
            this.keyBox.Controls.Add(this.arrowsBox);
            this.keyBox.Controls.Add(this.wasdBtn);
            this.keyBox.Controls.Add(this.arrowBtn);
            this.keyBox.Controls.Add(this.wasdBox);
            this.keyBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyBox.Location = new System.Drawing.Point(22, 133);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(223, 115);
            this.keyBox.TabIndex = 4;
            this.keyBox.TabStop = false;
            this.keyBox.Text = "Key Controller";
            // 
            // arrowsBox
            // 
            this.arrowsBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowsBox.BackgroundImage = global::TheSurvivor.Properties.Resources.Arrows;
            this.arrowsBox.Location = new System.Drawing.Point(108, 31);
            this.arrowsBox.Name = "arrowsBox";
            this.arrowsBox.Size = new System.Drawing.Size(88, 65);
            this.arrowsBox.TabIndex = 6;
            this.arrowsBox.TabStop = false;
            // 
            // wasdBtn
            // 
            this.wasdBtn.AutoSize = true;
            this.wasdBtn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wasdBtn.Location = new System.Drawing.Point(19, 58);
            this.wasdBtn.Name = "wasdBtn";
            this.wasdBtn.Size = new System.Drawing.Size(65, 21);
            this.wasdBtn.TabIndex = 1;
            this.wasdBtn.TabStop = true;
            this.wasdBtn.Text = "WASD";
            this.wasdBtn.UseVisualStyleBackColor = true;
            this.wasdBtn.CheckedChanged += new System.EventHandler(this.wasdBtn_CheckedChanged);
            // 
            // arrowBtn
            // 
            this.arrowBtn.AutoSize = true;
            this.arrowBtn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrowBtn.Location = new System.Drawing.Point(19, 31);
            this.arrowBtn.Name = "arrowBtn";
            this.arrowBtn.Size = new System.Drawing.Size(83, 21);
            this.arrowBtn.TabIndex = 0;
            this.arrowBtn.TabStop = true;
            this.arrowBtn.Text = "Arrows";
            this.arrowBtn.UseVisualStyleBackColor = true;
            this.arrowBtn.CheckedChanged += new System.EventHandler(this.arrowBtn_CheckedChanged);
            // 
            // wasdBox
            // 
            this.wasdBox.BackgroundImage = global::TheSurvivor.Properties.Resources.WASDN;
            this.wasdBox.Location = new System.Drawing.Point(108, 31);
            this.wasdBox.Name = "wasdBox";
            this.wasdBox.Size = new System.Drawing.Size(88, 65);
            this.wasdBox.TabIndex = 7;
            this.wasdBox.TabStop = false;
            // 
            // soundBox
            // 
            this.soundBox.BackColor = System.Drawing.Color.Transparent;
            this.soundBox.Controls.Add(this.onBox);
            this.soundBox.Controls.Add(this.offBox);
            this.soundBox.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundBox.Location = new System.Drawing.Point(268, 133);
            this.soundBox.Name = "soundBox";
            this.soundBox.Size = new System.Drawing.Size(211, 115);
            this.soundBox.TabIndex = 5;
            this.soundBox.TabStop = false;
            this.soundBox.Text = "Sound";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.onBox);
            this.groupBox1.Controls.Add(this.offBtn);
            this.groupBox1.Controls.Add(this.onBtn);
            this.groupBox1.Controls.Add(this.offBox);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(268, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 115);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sound";
            // 
            // offBtn2
            // 
            this.offBtn.AutoSize = true;
            this.offBtn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offBtn.Location = new System.Drawing.Point(27, 58);
            this.offBtn.Name = "offBtn2";
            this.offBtn.Size = new System.Drawing.Size(50, 21);
            this.offBtn.TabIndex = 2;
            this.offBtn.TabStop = true;
            this.offBtn.Text = "Off";
            this.offBtn.UseVisualStyleBackColor = true;
            this.offBtn.CheckedChanged += new System.EventHandler(this.offBtn_CheckedChanged);
            // 
            // onBtn2
            // 
            this.onBtn.AutoSize = true;
            this.onBtn.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onBtn.Location = new System.Drawing.Point(27, 31);
            this.onBtn.Name = "onBtn2";
            this.onBtn.Size = new System.Drawing.Size(45, 21);
            this.onBtn.TabIndex = 1;
            this.onBtn.TabStop = true;
            this.onBtn.Text = "On";
            this.onBtn.UseVisualStyleBackColor = true;
            this.onBtn.CheckedChanged += new System.EventHandler(this.onBtn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.onBox.BackColor = System.Drawing.Color.Transparent;
            this.onBox.BackgroundImage = global::TheSurvivor.Properties.Resources.soundsOnN;
            this.onBox.Location = new System.Drawing.Point(100, 31);
            this.onBox.Name = "pictureBox1";
            this.onBox.Size = new System.Drawing.Size(79, 59);
            this.onBox.TabIndex = 8;
            this.onBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.offBox.BackgroundImage = global::TheSurvivor.Properties.Resources.sonudOff;
            this.offBox.Location = new System.Drawing.Point(100, 31);
            this.offBox.Name = "pictureBox2";
            this.offBox.Size = new System.Drawing.Size(79, 59);
            this.offBox.TabIndex = 9;
            this.offBox.TabStop = false;
            // 
            // PauseScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.PauseScreenForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(512, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.soundBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.returnToGame);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PauseScreen";
            this.Deactivate += new System.EventHandler(this.PauseScreen_Deactivate);
            this.keyBox.ResumeLayout(false);
            this.keyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arrowsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wasdBox)).EndInit();
            this.soundBox.ResumeLayout(false);
            this.soundBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Button returnToGame;
        private System.Windows.Forms.GroupBox keyBox;
        private System.Windows.Forms.GroupBox soundBox;
        private System.Windows.Forms.RadioButton wasdBtn;
        private System.Windows.Forms.RadioButton arrowBtn;
        private System.Windows.Forms.PictureBox arrowsBox;
        private System.Windows.Forms.PictureBox wasdBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox onBox;
        private System.Windows.Forms.RadioButton offBtn;
        private System.Windows.Forms.RadioButton onBtn;
        private System.Windows.Forms.PictureBox offBox;
    }
}