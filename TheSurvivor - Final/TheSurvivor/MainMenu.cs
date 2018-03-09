using System;
using System.Windows.Forms;
using System.Threading;

namespace TheSurvivor
{
    public partial class MainMenu : GameForm
    {
        public MainMenu(DataBase db)
        {
            this.db = db;
            db.Change = true;
            ChangeResolution(1024, 768);
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            db.Score = 0;
            db.Life = 20;
            if (Music.IsPlaying)
            {
                    Music.PlayLoop();
            }
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            db.Change = false;
            Thread tr = new Thread(RunLevel1);
            tr.Start();
            this.Close();
        }

        private void RunLevel1()
        {
            Level1 lv1 = new Level1(db);
            Application.Run(lv1);
        }

        private void option_button_Click(object sender, EventArgs e)
        {
            db.Change = false;
            Thread tr = new Thread(RunOption);
            tr.Start();
            this.Close();
        }

        private void RunOption()
        {
            Options opt = new Options(db);
            Application.Run(opt);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

