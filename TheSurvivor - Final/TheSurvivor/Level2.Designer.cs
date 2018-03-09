namespace TheSurvivor
{
    partial class Level2
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
            this.grass1 = new System.Windows.Forms.PictureBox();
            this.grass2 = new System.Windows.Forms.PictureBox();
            this.grass3 = new System.Windows.Forms.PictureBox();
            this.grass4 = new System.Windows.Forms.PictureBox();
            this.grass5 = new System.Windows.Forms.PictureBox();
            this.grass6 = new System.Windows.Forms.PictureBox();
            this.grass7 = new System.Windows.Forms.PictureBox();
            this.HPBar = new System.Windows.Forms.ProgressBar();
            this.HP = new System.Windows.Forms.Label();
            this.ScorePoints = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass7)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grass1
            // 
            this.grass1.BackColor = System.Drawing.Color.Transparent;
            this.grass1.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass1.Location = new System.Drawing.Point(227, 732);
            this.grass1.Name = "grass1";
            this.grass1.Size = new System.Drawing.Size(159, 10);
            this.grass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass1.TabIndex = 51;
            this.grass1.TabStop = false;
            // 
            // grass2
            // 
            this.grass2.BackColor = System.Drawing.Color.Transparent;
            this.grass2.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass2.Location = new System.Drawing.Point(607, 732);
            this.grass2.Name = "grass2";
            this.grass2.Size = new System.Drawing.Size(159, 10);
            this.grass2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass2.TabIndex = 52;
            this.grass2.TabStop = false;
            // 
            // grass3
            // 
            this.grass3.BackColor = System.Drawing.Color.Transparent;
            this.grass3.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass3.Location = new System.Drawing.Point(881, 395);
            this.grass3.Name = "grass3";
            this.grass3.Size = new System.Drawing.Size(143, 10);
            this.grass3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass3.TabIndex = 53;
            this.grass3.TabStop = false;
            // 
            // grass4
            // 
            this.grass4.BackColor = System.Drawing.Color.Transparent;
            this.grass4.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass4.Location = new System.Drawing.Point(84, 326);
            this.grass4.Name = "grass4";
            this.grass4.Size = new System.Drawing.Size(192, 10);
            this.grass4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass4.TabIndex = 54;
            this.grass4.TabStop = false;
            // 
            // grass5
            // 
            this.grass5.BackColor = System.Drawing.Color.Transparent;
            this.grass5.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass5.Location = new System.Drawing.Point(354, 323);
            this.grass5.Name = "grass5";
            this.grass5.Size = new System.Drawing.Size(180, 10);
            this.grass5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass5.TabIndex = 55;
            this.grass5.TabStop = false;
            // 
            // grass6
            // 
            this.grass6.BackColor = System.Drawing.Color.Transparent;
            this.grass6.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass6.Location = new System.Drawing.Point(218, 63);
            this.grass6.Name = "grass6";
            this.grass6.Size = new System.Drawing.Size(148, 10);
            this.grass6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass6.TabIndex = 56;
            this.grass6.TabStop = false;
            // 
            // grass7
            // 
            this.grass7.BackColor = System.Drawing.Color.Transparent;
            this.grass7.Image = global::TheSurvivor.Properties.Resources.Grass;
            this.grass7.Location = new System.Drawing.Point(566, 120);
            this.grass7.Name = "grass7";
            this.grass7.Size = new System.Drawing.Size(139, 10);
            this.grass7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grass7.TabIndex = 57;
            this.grass7.TabStop = false;
            // 
            // HPBar
            // 
            this.HPBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.HPBar.ForeColor = System.Drawing.Color.Green;
            this.HPBar.Location = new System.Drawing.Point(460, 4);
            this.HPBar.Maximum = 20;
            this.HPBar.Name = "HPBar";
            this.HPBar.Size = new System.Drawing.Size(100, 23);
            this.HPBar.TabIndex = 58;
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.BackColor = System.Drawing.Color.Transparent;
            this.HP.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HP.ForeColor = System.Drawing.Color.LimeGreen;
            this.HP.Location = new System.Drawing.Point(423, 4);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(41, 22);
            this.HP.TabIndex = 59;
            this.HP.Text = "HP:";
            // 
            // ScorePoints
            // 
            this.ScorePoints.AutoSize = true;
            this.ScorePoints.BackColor = System.Drawing.Color.Transparent;
            this.ScorePoints.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePoints.ForeColor = System.Drawing.Color.LimeGreen;
            this.ScorePoints.Location = new System.Drawing.Point(316, 4);
            this.ScorePoints.Name = "ScorePoints";
            this.ScorePoints.Size = new System.Drawing.Size(0, 22);
            this.ScorePoints.TabIndex = 60;
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLable.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLable.ForeColor = System.Drawing.Color.LimeGreen;
            this.ScoreLable.Location = new System.Drawing.Point(248, 4);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(58, 22);
            this.ScoreLable.TabIndex = 61;
            this.ScoreLable.Text = "Score:";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.grass1);
            this.Controls.Add(this.grass2);
            this.Controls.Add(this.grass3);
            this.Controls.Add(this.grass7);
            this.Controls.Add(this.grass6);
            this.Controls.Add(this.grass5);
            this.Controls.Add(this.grass4);
            this.Controls.Add(this.HPBar);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.ScorePoints);
            this.Controls.Add(this.ScoreLable);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Level2";
            this.Activated += new System.EventHandler(this.Level2_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.grass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox grass1;
        private System.Windows.Forms.PictureBox grass2;
        private System.Windows.Forms.PictureBox grass3;
        private System.Windows.Forms.PictureBox grass4;
        private System.Windows.Forms.PictureBox grass5;
        private System.Windows.Forms.PictureBox grass6;
        private System.Windows.Forms.PictureBox grass7;
        private System.Windows.Forms.ProgressBar HPBar;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label ScorePoints;
        private System.Windows.Forms.Label ScoreLable;
    }
}