namespace TheSurvivor
{
    partial class Level1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.hpl = new System.Windows.Forms.Label();
            this.scoreP = new System.Windows.Forms.Label();
            this.Scorelab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.hpl);
            this.panel1.Controls.Add(this.scoreP);
            this.panel1.Controls.Add(this.Scorelab);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 772);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pb1.ForeColor = System.Drawing.Color.Lime;
            this.pb1.Location = new System.Drawing.Point(238, 6);
            this.pb1.Maximum = 20;
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(100, 23);
            this.pb1.TabIndex = 5;
            // 
            // hpl
            // 
            this.hpl.AutoSize = true;
            this.hpl.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hpl.ForeColor = System.Drawing.Color.Lime;
            this.hpl.Location = new System.Drawing.Point(191, 6);
            this.hpl.Name = "hpl";
            this.hpl.Size = new System.Drawing.Size(41, 24);
            this.hpl.TabIndex = 4;
            this.hpl.Text = "HP";
            // 
            // scoreP
            // 
            this.scoreP.AutoSize = true;
            this.scoreP.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreP.ForeColor = System.Drawing.Color.Orange;
            this.scoreP.Location = new System.Drawing.Point(75, 2);
            this.scoreP.Name = "scoreP";
            this.scoreP.Size = new System.Drawing.Size(23, 28);
            this.scoreP.TabIndex = 3;
            this.scoreP.Text = "0";
            // 
            // Scorelab
            // 
            this.Scorelab.AutoSize = true;
            this.Scorelab.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorelab.ForeColor = System.Drawing.Color.Orange;
            this.Scorelab.Location = new System.Drawing.Point(4, 6);
            this.Scorelab.Name = "Scorelab";
            this.Scorelab.Size = new System.Drawing.Size(74, 24);
            this.Scorelab.TabIndex = 2;
            this.Scorelab.Text = "Score:";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.newBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Level1";
            this.Activated += new System.EventHandler(this.Level1_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Scorelab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label scoreP;
        private System.Windows.Forms.Label hpl;
        private System.Windows.Forms.ProgressBar pb1;
    }
}