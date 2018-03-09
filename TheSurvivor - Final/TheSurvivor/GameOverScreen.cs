using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace TheSurvivor
{
    public partial class GameOverScreen : GameForm
    {
        private FileManager fManager = new FileManager();

        public GameOverScreen(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            submitBtn.Location = new Point((this.ClientRectangle.Width - submitBtn.Width) / 2, (this.ClientRectangle.Height - 100));

            if (Music.IsPlaying)
            {
                Music.Playend();
            }
            if (CheckIfScore())
            {
                submitBtn.BackgroundImage = global::TheSurvivor.Properties.Resources.BtnNewHighScore;
                this.BackgroundImage = global::TheSurvivor.Properties.Resources.NewHighScore;
                nameTextBox.Visible = true;
            }
            else
            {
                this.BackgroundImage = global::TheSurvivor.Properties.Resources.NoHighScore;
                submitBtn.BackgroundImage = global::TheSurvivor.Properties.Resources.BtnNoHighScore;      
            }
            submitBtn.Visible = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private bool CheckIfScore()
        {
            if (db.Score > (int.Parse(fManager.Scores[4].Text)))
            {
                    return true;
            }
            return false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void RunCredits()
        {
            Credits hs = new Credits(db);
            Application.Run(hs);
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }

        private void Submit()
        {
            if (CheckIfScore())
            {
                fManager.UpdateToHS(nameTextBox.Text, db.Score);
                fManager.SaveData(fManager.Names, fManager.Scores);
            }
            Thread tr = new Thread(RunCredits);
            tr.Start();
            this.Close();
        }
    }
}
