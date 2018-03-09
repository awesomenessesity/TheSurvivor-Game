using System;
using System.Windows.Forms;
using System.Threading;

namespace TheSurvivor
{
    public partial class HighScore : GameForm
    {
        private Label[] names = new Label[5];
        private Label[] scores = new Label[5];
        private FileManager fm = new FileManager();

        public HighScore(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            InitializeMyComponents();
            UpdateLabels();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            db.Score = 0;
            db.Life = 20;
            Thread tr = new Thread(RunMainMenu);
            tr.Start();
            this.Close();
        }

        private void InitializeMyComponents()
        {
            this.names[0] = new Label();
            this.scores[0] = new Label();
            this.names[1] = new Label();
            this.scores[1] = new Label();
            this.names[2] = new Label();
            this.scores[2] = new Label();
            this.names[3] = new Label();
            this.scores[3] = new Label();
            this.names[4] = new Label();
            this.scores[4] = new Label();
            // 
            // name1
            // 
            this.names[0].AutoSize = true;
            this.names[0].BackColor = System.Drawing.Color.Transparent;
            this.names[0].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names[0].ForeColor = System.Drawing.Color.Black;
            this.names[0].Location = new System.Drawing.Point(369, 352);
            this.names[0].Name = "name1";
            this.names[0].Size = new System.Drawing.Size(57, 25);
            this.names[0].TabIndex = 1;
            // 
            // score1
            // 
            this.scores[0].AutoSize = true;
            this.scores[0].BackColor = System.Drawing.Color.Transparent;
            this.scores[0].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores[0].ForeColor = System.Drawing.Color.Black;
            this.scores[0].Location = new System.Drawing.Point(582, 352);
            this.scores[0].Name = "score1";
            this.scores[0].Size = new System.Drawing.Size(60, 25);
            this.scores[0].TabIndex = 11;
            // 
            // name2
            // 
            this.names[1].AutoSize = true;
            this.names[1].BackColor = System.Drawing.Color.Transparent;
            this.names[1].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names[1].ForeColor = System.Drawing.Color.Black;
            this.names[1].Location = new System.Drawing.Point(369, 404);
            this.names[1].Name = "name2";
            this.names[1].Size = new System.Drawing.Size(59, 25);
            this.names[1].TabIndex = 12;
            // 
            // score2
            // 
            this.scores[1].AutoSize = true;
            this.scores[1].BackColor = System.Drawing.Color.Transparent;
            this.scores[1].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores[1].ForeColor = System.Drawing.Color.Black;
            this.scores[1].Location = new System.Drawing.Point(582, 404);
            this.scores[1].Name = "score2";
            this.scores[1].Size = new System.Drawing.Size(48, 25);
            this.scores[1].TabIndex = 13;
            // 
            // name3
            // 
            this.names[2].AutoSize = true;
            this.names[2].BackColor = System.Drawing.Color.Transparent;
            this.names[2].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names[2].ForeColor = System.Drawing.Color.Black;
            this.names[2].Location = new System.Drawing.Point(369, 458);
            this.names[2].Name = "name3";
            this.names[2].Size = new System.Drawing.Size(73, 25);
            this.names[2].TabIndex = 14;
            // 
            // score3
            // 
            this.scores[2].AutoSize = true;
            this.scores[2].BackColor = System.Drawing.Color.Transparent;
            this.scores[2].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores[2].ForeColor = System.Drawing.Color.Black;
            this.scores[2].Location = new System.Drawing.Point(582, 458);
            this.scores[2].Name = "score3";
            this.scores[2].Size = new System.Drawing.Size(48, 25);
            this.scores[2].TabIndex = 15;
            // 
            // name4
            // 
            this.names[3].AutoSize = true;
            this.names[3].BackColor = System.Drawing.Color.Transparent;
            this.names[3].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names[3].ForeColor = System.Drawing.Color.Black;
            this.names[3].Location = new System.Drawing.Point(369, 499);
            this.names[3].Name = "name4";
            this.names[3].Size = new System.Drawing.Size(51, 25);
            this.names[3].TabIndex = 16;
            // 
            // score4
            // 
            this.scores[3].AutoSize = true;
            this.scores[3].BackColor = System.Drawing.Color.Transparent;
            this.scores[3].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores[3].ForeColor = System.Drawing.Color.Black;
            this.scores[3].Location = new System.Drawing.Point(582, 499);
            this.scores[3].Name = "score4";
            this.scores[3].Size = new System.Drawing.Size(48, 25);
            this.scores[3].TabIndex = 17;
            // 
            // name5
            // 
            this.names[4].AutoSize = true;
            this.names[4].BackColor = System.Drawing.Color.Transparent;
            this.names[4].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names[4].ForeColor = System.Drawing.Color.Black;
            this.names[4].Location = new System.Drawing.Point(369, 549);
            this.names[4].Name = "name5";
            this.names[4].Size = new System.Drawing.Size(67, 25);
            this.names[4].TabIndex = 18;
            // 
            // score5
            // 
            this.scores[4].AutoSize = true;
            this.scores[4].BackColor = System.Drawing.Color.Transparent;
            this.scores[4].Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores[4].ForeColor = System.Drawing.Color.Black;
            this.scores[4].Location = new System.Drawing.Point(582, 549);
            this.scores[4].Name = "score5";
            this.scores[4].Size = new System.Drawing.Size(48, 25);
            this.scores[4].TabIndex = 19;
            //
            //highscore
            //
            this.Controls.Add(this.scores[4]);
            this.Controls.Add(this.names[4]);
            this.Controls.Add(this.scores[3]);
            this.Controls.Add(this.names[3]);
            this.Controls.Add(this.scores[2]);
            this.Controls.Add(this.names[2]);
            this.Controls.Add(this.scores[1]);
            this.Controls.Add(this.names[1]);
            this.Controls.Add(this.scores[0]);
            this.Controls.Add(this.names[0]);
        }

        private void UpdateLabels()
        {
            for (int i = 0; i < 5; i++)
            {
                names[i].Text = fm.Names[i].Text;
                scores[i].Text = fm.Scores[i].Text;
            }
        }

        private void RunMainMenu()
        {
            MainMenu mn = new MainMenu(db);
            Application.Run(mn);
        }
    }
}
