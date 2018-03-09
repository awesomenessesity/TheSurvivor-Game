using System;
using System.IO;
using System.Windows.Forms;


namespace TheSurvivor
{
    public class FileManager
    {
        private Label[] names = new Label[5];
        private Label[] scores = new Label[5];

        public FileManager()
        {
            FileStream fileOpener = new FileStream("HighScore.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None);
            StreamReader sr = new StreamReader(fileOpener);
            for (int i = 0; i < 5; i++)
            {
                names[i] = new Label();
                scores[i] = new Label();
                names[i].Text = sr.ReadLine();
                scores[i].Text = sr.ReadLine();
            }
            //check if scores are legit
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    int t = int.Parse(scores[i].Text);
                }
                catch //if not you messed with our highscore file, therefore screw your high score, here is new stuff
                { 
                    scores[0].Text = "15000";
                    scores[1].Text = "10000";
                    scores[2].Text = "5000";
                    scores[3].Text = "2500";
                    scores[4].Text = "1000";
                    names[0].Text = "Dan";
                    names[1].Text = "Eran";
                    names[2].Text = "Sasha";
                    names[3].Text = "Oron";
                    names[4].Text = "Dekel";
                    break;
                }                  
            }
     
            sr.DiscardBufferedData();
            sr.Close();
            fileOpener.Close();
        }

        public void SaveData(Label[] names, Label[] scores)
        {
            File.WriteAllText("HighScore.txt", String.Empty);
            FileStream fileOpener = new FileStream("HighScore.txt", FileMode.Open, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fileOpener);
            for (int i = 0; i < 5; i++)
            {
                sw.WriteLine(names[i].Text);
                sw.WriteLine(scores[i].Text);
            }
            sw.Flush();
            sw.Close();
            fileOpener.Close();
        }

        public void UpdateToHS(string name, int points)
        {
            int[] score = new int[5];
            for (int i = 0; i < 4; i++)
            {
                score[i] = int.Parse(scores[i].Text);
            }
            score[4] = points;
            names[4].Text = name;

            for (int i = 4; i > 0; i--)
            {
                if (score[i] > score[i - 1])
                {
                    //sorting scores
                    int temp = score[i - 1];
                    score[i - 1] = score[i];
                    score[i] = temp;
                    //sorting names
                    Label templ = names[i - 1];
                    names[i - 1] = names[i];
                    names[i] = templ;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                scores[i].Text = score[i].ToString();
            }
        }

        public Label[] Names
        {
            get { return names; }
        }

        public Label[] Scores
        {
            get { return scores; }
        }
    }
}