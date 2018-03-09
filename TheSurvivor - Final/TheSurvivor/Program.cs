using System;
using System.Windows.Forms;

namespace TheSurvivor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DataBase db = new DataBase(20, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, true,false);
            MainMenu mn = new MainMenu(db);
            Application.Run(mn);
        }
    }
}