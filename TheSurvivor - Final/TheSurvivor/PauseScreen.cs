using System;
using System.Threading;
using System.Windows.Forms;

namespace TheSurvivor
{
    public partial class PauseScreen : GameForm
    {
        private GameForm gm;

        public PauseScreen(GameForm gm)
        {
            this.db = gm.db;
            this.gm = gm;
            InitializeComponent();
            this.Left = 256;
            this.Top = 192;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            if (Music.IsPlaying)
            {
                onBtn.Checked = true;
                onBox.Visible = true;
                offBox.Visible = false;
            }
            else
            {
                offBtn.Checked = true;
                onBox.Visible = false;
                offBox.Visible = true;
            }
            if (!db.Wasd)
            {
                arrowBtn.Checked = true;
                arrowsBox.Visible = true;
                wasdBox.Visible = false;
            }
            else
            {
                wasdBtn.Checked = true;
                arrowsBox.Visible = false;
                wasdBox.Visible = true;
            }
        }

        private void returnToGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            gm.Close();
            Thread tr = new Thread(RunMainMenue);
            tr.Start();
        }

        private void RunMainMenue()
        {
            MainMenu mn = new MainMenu(this.db);
            Application.Run(mn);
        }

        private void PauseScreen_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arrowBtn_CheckedChanged(object sender, EventArgs e)
        {
            arrowsBox.Visible = true;
            wasdBox.Visible = false;
            db.Wasd = false;
        }

        private void wasdBtn_CheckedChanged(object sender, EventArgs e)
        {
            arrowsBox.Visible = false;
            wasdBox.Visible = true;
            db.Wasd = true;
        }

        private void onBtn_CheckedChanged(object sender, EventArgs e)
        {
            onBox.Visible = true;
            offBox.Visible = false;
            Music.IsPlaying = true;
            Music.PlayLoop();
        }

        private void offBtn_CheckedChanged(object sender, EventArgs e)
        {
            onBox.Visible = false;
            offBox.Visible = true;
            Music.Stop();
            Music.IsPlaying = false;
        }
    }
}
