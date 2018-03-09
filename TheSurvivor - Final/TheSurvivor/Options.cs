using System;
using System.Threading;
using System.Windows.Forms;

namespace TheSurvivor
{
    public partial class Options : GameForm
    {
        public Options(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            if (Music.IsPlaying)
            {
                onRtn.Checked = true;
                onpicBox.Visible = true;
                offpicBox.Visible = false;
            }
            else
            {
                offRbtn.Checked = true;
                onpicBox.Visible = false;
                offpicBox.Visible = true;
            }
            if (!db.Wasd)
            {
                arrowRbtn.Checked = true;
                arrowspicBox.Visible = true;
                wasdpicBox.Visible = false;
            }
            else
            {
                wasdRbtn.Checked = true;
                arrowspicBox.Visible = false;
                wasdpicBox.Visible = true;
            }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void onRtn_CheckedChanged(object sender, EventArgs e)
        {
                onpicBox.Visible = true;
                offpicBox.Visible = false;
                Music.IsPlaying = true;
                Music.PlayLoop();
        }

        private void offRbtn_CheckedChanged(object sender, EventArgs e)
        {
                onpicBox.Visible = false;
                offpicBox.Visible = true;
                Music.Stop();
                Music.IsPlaying = false;
        }

        private void arrowRbtn_CheckedChanged(object sender, EventArgs e)
        {
            arrowspicBox.Visible = true;
            wasdpicBox.Visible = false;
            db.Wasd = false;
        }

        private void wasdRbtn_CheckedChanged(object sender, EventArgs e)
        {
            arrowspicBox.Visible = false;
            wasdpicBox.Visible = true;
            db.Wasd = true;
        }

        private void returnToMainBtn_Click(object sender, EventArgs e)
        {
            Thread tr = new Thread(RunMainMenue);
            tr.Start();
            this.Close();
        }

        private void RunMainMenue()
        {
            MainMenu mn = new MainMenu(db);
            Application.Run(mn);
        }
    }
}

