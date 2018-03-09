using System;
using System.Media;

namespace TheSurvivor
{
    public class DataBase
    {
        private int life, score, screenWidth, screenHeight;
        private bool change,wasd;

        public DataBase(int life, int score, int screenWidth, int screenHeight, bool change,bool wasd)
        {
            this.life = life;
            this.score = score;
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            this.change = change;
            this.wasd = wasd;        
        }

        public int Life
        {
            get { return life; }
            set { this.life = value; }
        }

        public int Score
        {
            get { return score; }
            set { this.score = value; }
        }

        public int ScreenWidth
        {
            get { return screenWidth; }
            set { this.screenWidth = value; }
        }

        public int ScreenHeight
        {
            get { return screenHeight; }
            set { this.screenHeight = value; }
        }

        public bool Change
        {
            get { return change; }
            set { this.change = value; }
        }

        public bool Wasd
        {
            get { return wasd; }
            set { wasd = value; }
        }
    }
}
