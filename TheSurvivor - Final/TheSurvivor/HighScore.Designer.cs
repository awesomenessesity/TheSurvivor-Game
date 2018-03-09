namespace TheSurvivor
{
    partial class HighScore
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.Button();
            this.throphy = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.throphy)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(583, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(370, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.BackgroundImage = global::TheSurvivor.Properties.Resources.buttonHighSc;
            this.mainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.mainMenu.FlatAppearance.BorderSize = 0;
            this.mainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainMenu.Location = new System.Drawing.Point(408, 643);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(182, 65);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.UseVisualStyleBackColor = false;
            this.mainMenu.Click += new System.EventHandler(this.mainMenu_Click);
            // 
            // throphy
            // 
            this.throphy.BackColor = System.Drawing.Color.Transparent;
            this.throphy.Image = global::TheSurvivor.Properties.Resources.trophyNew31;
            this.throphy.Location = new System.Drawing.Point(395, 80);
            this.throphy.Name = "throphy";
            this.throphy.Size = new System.Drawing.Size(227, 228);
            this.throphy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.throphy.TabIndex = 22;
            this.throphy.TabStop = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Algerian", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1024, 131);
            this.label11.TabIndex = 10;
            this.label11.Text = "HIGH SCORE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.HighBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.throphy);
            this.Controls.Add(this.label11);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HighScore";
            ((System.ComponentModel.ISupportInitialize)(this.throphy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainMenu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox throphy;
    }
}