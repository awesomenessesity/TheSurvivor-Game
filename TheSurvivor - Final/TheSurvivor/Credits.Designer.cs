namespace TheSurvivor
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.creditsText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.signature = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.signature)).BeginInit();
            this.SuspendLayout();
            // 
            // creditsText
            // 
            this.creditsText.AutoSize = true;
            this.creditsText.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsText.ForeColor = System.Drawing.SystemColors.Window;
            this.creditsText.Location = new System.Drawing.Point(56, 745);
            this.creditsText.Name = "creditsText";
            this.creditsText.Size = new System.Drawing.Size(906, 5056);
            this.creditsText.TabIndex = 0;
            this.creditsText.Text = resources.GetString("creditsText.Text");
            this.creditsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // signature
            // 
            this.signature.BackColor = System.Drawing.Color.Transparent;
            this.signature.Image = global::TheSurvivor.Properties.Resources.DevTeam1;
            this.signature.Location = new System.Drawing.Point(440, 5900);
            this.signature.Name = "signature";
            this.signature.Size = new System.Drawing.Size(127, 182);
            this.signature.TabIndex = 1;
            this.signature.TabStop = false;
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.signature);
            this.Controls.Add(this.creditsText);
            this.Name = "Credits";
            this.Text = "Credits";
            ((System.ComponentModel.ISupportInitialize)(this.signature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creditsText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox signature;
    }
}