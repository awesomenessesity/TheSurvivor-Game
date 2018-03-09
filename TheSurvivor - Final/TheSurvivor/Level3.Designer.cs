namespace TheSurvivor
{
    partial class Level3
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
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.HPBar = new System.Windows.Forms.ProgressBar();
            this.HP = new System.Windows.Forms.Label();
            this.ScoreLable = new System.Windows.Forms.Label();
            this.ScorePoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // HPBar
            // 
            this.HPBar.BackColor = System.Drawing.Color.DarkGreen;
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
            this.HP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HP.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.HP.Location = new System.Drawing.Point(425, 4);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(41, 24);
            this.HP.TabIndex = 59;
            this.HP.Text = "HP:";
            // 
            // ScoreLable
            // 
            this.ScoreLable.AutoSize = true;
            this.ScoreLable.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScoreLable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScoreLable.Location = new System.Drawing.Point(248, 4);
            this.ScoreLable.Name = "ScoreLable";
            this.ScoreLable.Size = new System.Drawing.Size(65, 24);
            this.ScoreLable.TabIndex = 61;
            this.ScoreLable.Text = "Score:";
            // 
            // ScorePoints
            // 
            this.ScorePoints.AutoSize = true;
            this.ScorePoints.BackColor = System.Drawing.Color.Transparent;
            this.ScorePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ScorePoints.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ScorePoints.Location = new System.Drawing.Point(319, 4);
            this.ScorePoints.Name = "ScorePoints";
            this.ScorePoints.Size = new System.Drawing.Size(0, 24);
            this.ScorePoints.TabIndex = 62;
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.backgroung_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.ScorePoints);
            this.Controls.Add(this.HPBar);
            this.Controls.Add(this.HP);
            this.Controls.Add(this.ScoreLable);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Level3";
            this.Activated += new System.EventHandler(this.Level3_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar HPBar;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label ScoreLable;
        private System.Windows.Forms.Label ScorePoints;
    }
}