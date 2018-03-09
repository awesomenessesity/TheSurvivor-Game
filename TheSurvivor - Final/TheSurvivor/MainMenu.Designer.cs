namespace TheSurvivor
{
    partial class MainMenu
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
            this.option_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.mainMenuGif = new System.Windows.Forms.PictureBox();
            this.mainMenuButtons = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            this.SuspendLayout();
            // 
            // option_button
            // 
            this.option_button.BackColor = System.Drawing.Color.Transparent;
            this.option_button.BackgroundImage = global::TheSurvivor.Properties.Resources.OptionButton;
            this.option_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_button.FlatAppearance.BorderSize = 0;
            this.option_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.option_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.option_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option_button.Location = new System.Drawing.Point(398, 364);
            this.option_button.Name = "option_button";
            this.option_button.Size = new System.Drawing.Size(151, 42);
            this.option_button.TabIndex = 1;
            this.option_button.UseVisualStyleBackColor = false;
            this.option_button.Click += new System.EventHandler(this.option_button_Click);
            // 
            // exite_button
            // 
            this.exit_button.BackColor = System.Drawing.Color.Transparent;
            this.exit_button.BackgroundImage = global::TheSurvivor.Properties.Resources.ExitButton;
            this.exit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Location = new System.Drawing.Point(482, 435);
            this.exit_button.Name = "exite_button";
            this.exit_button.Size = new System.Drawing.Size(146, 42);
            this.exit_button.TabIndex = 2;
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Transparent;
            this.start_button.BackgroundImage = global::TheSurvivor.Properties.Resources.StartButton;
            this.start_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Location = new System.Drawing.Point(474, 303);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(154, 41);
            this.start_button.TabIndex = 0;
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // mainMenuGif
            // 
            this.mainMenuGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainMenuGif.Image = global::TheSurvivor.Properties.Resources.MainMenuGif;
            this.mainMenuGif.Location = new System.Drawing.Point(0, 0);
            this.mainMenuGif.Name = "mainMenuGif";
            this.mainMenuGif.Size = new System.Drawing.Size(1024, 768);
            this.mainMenuGif.TabIndex = 3;
            this.mainMenuGif.TabStop = false;
            // 
            // mainMenuButtons
            // 
            this.mainMenuButtons.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuButtons.BackgroundImage = global::TheSurvivor.Properties.Resources.MainMenuButton;
            this.mainMenuButtons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuButtons.Location = new System.Drawing.Point(370, 282);
            this.mainMenuButtons.Name = "mainMenuButtons";
            this.mainMenuButtons.Size = new System.Drawing.Size(287, 365);
            this.mainMenuButtons.TabIndex = 4;
            this.mainMenuButtons.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BackgroundImage = global::TheSurvivor.Properties.Resources.Title;
            this.title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.title.Location = new System.Drawing.Point(269, 49);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(500, 78);
            this.title.TabIndex = 5;
            this.title.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::TheSurvivor.Properties.Resources.MainMenuGif;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.title);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.option_button);
            this.Controls.Add(this.mainMenuButtons);
            this.Controls.Add(this.mainMenuGif);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button option_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox mainMenuGif;
        private System.Windows.Forms.PictureBox mainMenuButtons;
        private System.Windows.Forms.PictureBox title;
    }
}