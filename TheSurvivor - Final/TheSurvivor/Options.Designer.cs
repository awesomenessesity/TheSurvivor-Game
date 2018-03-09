namespace TheSurvivor
{
    partial class Options
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
            this.wasdRbtn = new System.Windows.Forms.RadioButton();
            this.arrowRbtn = new System.Windows.Forms.RadioButton();
            this.ControllersBox = new System.Windows.Forms.GroupBox();
            this.wasdpicBox = new System.Windows.Forms.PictureBox();
            this.arrowspicBox = new System.Windows.Forms.PictureBox();
            this.MusicBox = new System.Windows.Forms.GroupBox();
            this.onpicBox = new System.Windows.Forms.PictureBox();
            this.offRbtn = new System.Windows.Forms.RadioButton();
            this.onRtn = new System.Windows.Forms.RadioButton();
            this.offpicBox = new System.Windows.Forms.PictureBox();
            this.returnToMainBtn = new System.Windows.Forms.Button();
            this.ControllersBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wasdpicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowspicBox)).BeginInit();
            this.MusicBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onpicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offpicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wasdRbtn
            // 
            this.wasdRbtn.AutoSize = true;
            this.wasdRbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.wasdRbtn.Location = new System.Drawing.Point(6, 74);
            this.wasdRbtn.Name = "wasdRbtn";
            this.wasdRbtn.Size = new System.Drawing.Size(91, 25);
            this.wasdRbtn.TabIndex = 0;
            this.wasdRbtn.TabStop = true;
            this.wasdRbtn.Text = "WASD";
            this.wasdRbtn.UseVisualStyleBackColor = true;
            this.wasdRbtn.CheckedChanged += new System.EventHandler(this.wasdRbtn_CheckedChanged);
            // 
            // arrowRbtn
            // 
            this.arrowRbtn.AutoSize = true;
            this.arrowRbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.arrowRbtn.Location = new System.Drawing.Point(6, 42);
            this.arrowRbtn.Name = "arrowRbtn";
            this.arrowRbtn.Size = new System.Drawing.Size(108, 25);
            this.arrowRbtn.TabIndex = 1;
            this.arrowRbtn.TabStop = true;
            this.arrowRbtn.Text = "Arrows ";
            this.arrowRbtn.UseVisualStyleBackColor = true;
            this.arrowRbtn.CheckedChanged += new System.EventHandler(this.arrowRbtn_CheckedChanged);
            // 
            // ControllersBox
            // 
            this.ControllersBox.BackColor = System.Drawing.Color.Transparent;
            this.ControllersBox.Controls.Add(this.wasdRbtn);
            this.ControllersBox.Controls.Add(this.arrowRbtn);
            this.ControllersBox.Controls.Add(this.wasdpicBox);
            this.ControllersBox.Controls.Add(this.arrowspicBox);
            this.ControllersBox.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControllersBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ControllersBox.Location = new System.Drawing.Point(173, 410);
            this.ControllersBox.Name = "ControllersBox";
            this.ControllersBox.Size = new System.Drawing.Size(306, 135);
            this.ControllersBox.TabIndex = 2;
            this.ControllersBox.TabStop = false;
            this.ControllersBox.Text = "Key Controllers";
            // 
            // wasdpicBox
            // 
            this.wasdpicBox.BackColor = System.Drawing.Color.Transparent;
            this.wasdpicBox.BackgroundImage = global::TheSurvivor.Properties.Resources.WASDN;
            this.wasdpicBox.Location = new System.Drawing.Point(169, 42);
            this.wasdpicBox.Name = "wasdpicBox";
            this.wasdpicBox.Size = new System.Drawing.Size(88, 65);
            this.wasdpicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wasdpicBox.TabIndex = 7;
            this.wasdpicBox.TabStop = false;
            // 
            // arrowspicBox
            // 
            this.arrowspicBox.BackColor = System.Drawing.Color.Transparent;
            this.arrowspicBox.BackgroundImage = global::TheSurvivor.Properties.Resources.Arrows;
            this.arrowspicBox.Location = new System.Drawing.Point(169, 42);
            this.arrowspicBox.Name = "arrowspicBox";
            this.arrowspicBox.Size = new System.Drawing.Size(88, 65);
            this.arrowspicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrowspicBox.TabIndex = 6;
            this.arrowspicBox.TabStop = false;
            // 
            // MusicBox
            // 
            this.MusicBox.BackColor = System.Drawing.Color.Transparent;
            this.MusicBox.Controls.Add(this.onpicBox);
            this.MusicBox.Controls.Add(this.offRbtn);
            this.MusicBox.Controls.Add(this.onRtn);
            this.MusicBox.Controls.Add(this.offpicBox);
            this.MusicBox.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.MusicBox.Location = new System.Drawing.Point(560, 410);
            this.MusicBox.Name = "MusicBox";
            this.MusicBox.Size = new System.Drawing.Size(306, 135);
            this.MusicBox.TabIndex = 2;
            this.MusicBox.TabStop = false;
            this.MusicBox.Text = "Sounds";
            // 
            // onpicBox
            // 
            this.onpicBox.BackColor = System.Drawing.Color.Transparent;
            this.onpicBox.BackgroundImage = global::TheSurvivor.Properties.Resources.soundsOnN;
            this.onpicBox.Location = new System.Drawing.Point(161, 40);
            this.onpicBox.Name = "onpicBox";
            this.onpicBox.Size = new System.Drawing.Size(79, 59);
            this.onpicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onpicBox.TabIndex = 4;
            this.onpicBox.TabStop = false;
            // 
            // offRbtn
            // 
            this.offRbtn.AutoSize = true;
            this.offRbtn.Location = new System.Drawing.Point(6, 74);
            this.offRbtn.Name = "offRbtn";
            this.offRbtn.Size = new System.Drawing.Size(59, 25);
            this.offRbtn.TabIndex = 1;
            this.offRbtn.Text = "Off";
            this.offRbtn.UseVisualStyleBackColor = true;
            this.offRbtn.CheckedChanged += new System.EventHandler(this.offRbtn_CheckedChanged);
            // 
            // onRtn
            // 
            this.onRtn.AutoSize = true;
            this.onRtn.Checked = true;
            this.onRtn.Location = new System.Drawing.Point(6, 42);
            this.onRtn.Name = "onRtn";
            this.onRtn.Size = new System.Drawing.Size(56, 25);
            this.onRtn.TabIndex = 0;
            this.onRtn.TabStop = true;
            this.onRtn.Text = "On";
            this.onRtn.UseVisualStyleBackColor = true;
            this.onRtn.CheckedChanged += new System.EventHandler(this.onRtn_CheckedChanged);
            // 
            // offpicBox
            // 
            this.offpicBox.BackColor = System.Drawing.Color.Transparent;
            this.offpicBox.BackgroundImage = global::TheSurvivor.Properties.Resources.sonudOff;
            this.offpicBox.Location = new System.Drawing.Point(161, 40);
            this.offpicBox.Name = "offpicBox";
            this.offpicBox.Size = new System.Drawing.Size(79, 59);
            this.offpicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offpicBox.TabIndex = 5;
            this.offpicBox.TabStop = false;
            // 
            // returnToMainBtn
            // 
            this.returnToMainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.returnToMainBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.returnToMainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnToMainBtn.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.returnToMainBtn.Location = new System.Drawing.Point(367, 621);
            this.returnToMainBtn.Name = "returnToMainBtn";
            this.returnToMainBtn.Size = new System.Drawing.Size(300, 67);
            this.returnToMainBtn.TabIndex = 3;
            this.returnToMainBtn.Text = "Return Menu";
            this.returnToMainBtn.UseVisualStyleBackColor = false;
            this.returnToMainBtn.Click += new System.EventHandler(this.returnToMainBtn_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.OptionsForm211;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.returnToMainBtn);
            this.Controls.Add(this.MusicBox);
            this.Controls.Add(this.ControllersBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Options";
            this.ControllersBox.ResumeLayout(false);
            this.ControllersBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wasdpicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowspicBox)).EndInit();
            this.MusicBox.ResumeLayout(false);
            this.MusicBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.onpicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offpicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton wasdRbtn;
        private System.Windows.Forms.RadioButton arrowRbtn;
        private System.Windows.Forms.GroupBox ControllersBox;
        private System.Windows.Forms.GroupBox MusicBox;
        private System.Windows.Forms.RadioButton offRbtn;
        private System.Windows.Forms.RadioButton onRtn;
        private System.Windows.Forms.Button returnToMainBtn;
        private System.Windows.Forms.PictureBox onpicBox;
        private System.Windows.Forms.PictureBox offpicBox;
        private System.Windows.Forms.PictureBox arrowspicBox;
        private System.Windows.Forms.PictureBox wasdpicBox;
    }
}