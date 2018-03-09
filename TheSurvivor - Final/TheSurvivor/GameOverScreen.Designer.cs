namespace TheSurvivor
{
    partial class GameOverScreen
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.submitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBtn.FlatAppearance.BorderSize = 0;
            this.submitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.submitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.submitBtn.Location = new System.Drawing.Point(462, 547);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(73, 38);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Visible = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(462, 305);
            this.nameTextBox.MaxLength = 16;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 30);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameTextBox.Visible = false;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTextBox_KeyDown);
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.nameTextBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOverScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameOver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button submitBtn;
    }
}