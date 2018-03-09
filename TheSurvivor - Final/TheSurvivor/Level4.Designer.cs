namespace TheSurvivor
{
    partial class Level4
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hpBar = new System.Windows.Forms.ProgressBar();
            this.hp = new System.Windows.Forms.Label();
            this.dragonWind = new System.Windows.Forms.PictureBox();
            this.Fire2 = new System.Windows.Forms.PictureBox();
            this.Fire1 = new System.Windows.Forms.PictureBox();
            this.ScorePoints = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dragonWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hpBar
            // 
            this.hpBar.BackColor = System.Drawing.Color.DarkMagenta;
            this.hpBar.ForeColor = System.Drawing.Color.Tomato;
            this.hpBar.Location = new System.Drawing.Point(509, 6);
            this.hpBar.Maximum = 20;
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(100, 23);
            this.hpBar.TabIndex = 64;
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.BackColor = System.Drawing.Color.Transparent;
            this.hp.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.hp.Location = new System.Drawing.Point(443, 3);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(60, 24);
            this.hp.TabIndex = 63;
            this.hp.Text = "HP :";
            // 
            // dragonWind
            // 
            this.dragonWind.BackColor = System.Drawing.Color.Transparent;
            this.dragonWind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dragonWind.Image = global::TheSurvivor.Properties.Resources.DragonGust;
            this.dragonWind.Location = new System.Drawing.Point(859, 24);
            this.dragonWind.Name = "dragonWind";
            this.dragonWind.Size = new System.Drawing.Size(99, 82);
            this.dragonWind.TabIndex = 62;
            this.dragonWind.TabStop = false;
            // 
            // Fire2
            // 
            this.Fire2.BackColor = System.Drawing.Color.Transparent;
            this.Fire2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fire2.Image = global::TheSurvivor.Properties.Resources.FIRE2;
            this.Fire2.Location = new System.Drawing.Point(603, 722);
            this.Fire2.Name = "Fire2";
            this.Fire2.Size = new System.Drawing.Size(500, 58);
            this.Fire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Fire2.TabIndex = 4;
            this.Fire2.TabStop = false;
            // 
            // Fire1
            // 
            this.Fire1.BackColor = System.Drawing.Color.Transparent;
            this.Fire1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Fire1.Image = global::TheSurvivor.Properties.Resources.FIRE2;
            this.Fire1.Location = new System.Drawing.Point(108, 722);
            this.Fire1.Name = "Fire1";
            this.Fire1.Size = new System.Drawing.Size(500, 58);
            this.Fire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Fire1.TabIndex = 3;
            this.Fire1.TabStop = false;
            // 
            // ScorePoints
            // 
            this.ScorePoints.AutoSize = true;
            this.ScorePoints.BackColor = System.Drawing.Color.Transparent;
            this.ScorePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScorePoints.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScorePoints.Location = new System.Drawing.Point(316, 4);
            this.ScorePoints.Name = "ScorePoints";
            this.ScorePoints.Size = new System.Drawing.Size(0, 24);
            this.ScorePoints.TabIndex = 60;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.score.Location = new System.Drawing.Point(248, 4);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(67, 25);
            this.score.TabIndex = 61;
            this.score.Text = "Score:";
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.lvl4_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.hpBar);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.dragonWind);
            this.Controls.Add(this.Fire2);
            this.Controls.Add(this.Fire1);
            this.Controls.Add(this.ScorePoints);
            this.Controls.Add(this.score);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Level4";
            this.Activated += new System.EventHandler(this.Level4_Activated);
            this.Load += new System.EventHandler(this.Level4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level4_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level4_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dragonWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fire1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Fire1;
        private System.Windows.Forms.PictureBox Fire2;
        private System.Windows.Forms.Label ScorePoints;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox dragonWind;
        private System.Windows.Forms.Label hp;
        private System.Windows.Forms.ProgressBar hpBar;
    }
}