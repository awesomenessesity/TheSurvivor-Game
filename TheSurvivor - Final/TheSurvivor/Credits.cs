using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TheSurvivor
{
    public partial class Credits : GameForm
    {
        public Credits(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(signature.Bottom < 0)
            {
                Thread tr = new Thread(RunHighScore);
                tr.Start();
                this.Close();
            }
            creditsText.Top -= 5;
            signature.Top -= 5;
        }

        private void RunHighScore()
        {
            HighScore hs = new HighScore(db);
            Application.Run(hs);
        }
    }
}
