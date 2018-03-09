using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TheSurvivor
{
    public partial class Level3 : GameForm
    {
        private NonPlayer[] npo;
        private Player player;
        private Point respawn;
        private int velocity = 3;
        bool letMe, right, left, playerIsMoving;

        public Level3(DataBase db)
        {
            npo = new NonPlayer[25];
            respawn = new Point(30, 550);
            this.db = db;
            letMe = true; right = false; left = false; playerIsMoving = false;
            InitializeMyComponenets();
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            ScorePoints.Text = db.Score.ToString();
            HPBar.Increment(db.Life);
            ScorePoints.Text = db.Score.ToString();

            ScorePoints.SendToBack();
            ScoreLable.SendToBack();
            HPBar.SendToBack();
            HP.SendToBack();
            ChangeHpColor();
            if (Music.IsPlaying)
            {
                Music.Playlevel3();
            }
        }

        private void NextLevel()
        {
            db.Score += db.Life * 200;
            Thread tr = new Thread(RunNextLevel);
            tr.Start();
            this.Close();
        }

        private void RunNextLevel()
        {
            Level4 lv4 = new Level4(db);
            Application.Run(lv4);
        }

        private void ChangeHpColor()
        {
            if (db.Life < 7)
            {
                HPBar.ForeColor = Color.Red;
            }
            else if (db.Life < 11)
            {
                HPBar.ForeColor = Color.Yellow;
            }
            else
            {
                HPBar.ForeColor = Color.Green;
            }
        }

        private void LoseHP()
        {
            this.db.Life--;
            HPBar.Increment(-1);
            ChangeHpColor();
            if (this.db.Life == 0)
            {
                timer3.Stop();
                Thread tr = new Thread(RunGameOverScreen);
                tr.Start();
                this.Close();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            UpdateGame();
        }

        private void Jump()
        {
            if (player.Jump)
            {
                player.Gravity = -16.0f;
                player.Jump = false;
            }
        }

        private void UpdateGame()
        {
            //gravity : playing falling constantly
            player.Top += (int)player.Gravity;
            if (player.Gravity < 6)
            {
                player.Gravity += 1.0f;
            }
            //screen bounds
            if (player.Left < -16)
            {
                player.Left = -16;
            }
            if (player.Right > 1040)
            {
                player.Left = 1008;
            }
            //playing movement
            if (playerIsMoving)
            {

                if (left)
                {
                    MoveLeft();
                }
                if (right)
                {
                    MoveRight();
                }
            }
            //moving platforms
            MoveNPO(npo[10]);
            MoveNPO(npo[16]);

            player.Collision(npo);
        }

        private void MoveLeft()
        {
            player.Left -= player.Velocity;
        }

        private void MoveRight()
        {
            player.Left += player.Velocity;
        }

        private void MoveNPO(NonPlayer currentNPO)
        {
            if (currentNPO.Direct == (Direction.Left | Direction.Cycling)) //moving left
            {
                if (currentNPO.Left > currentNPO.StartX - currentNPO.Steps)
                {
                    currentNPO.Left -= velocity;
                }
                else
                {
                    currentNPO.Direct = (Direction.Right | Direction.Cycling);
                    currentNPO.StartX = currentNPO.Left;
                }
            }
            else if (currentNPO.Direct == (Direction.Right | Direction.Cycling))//moving right
            {
                if (currentNPO.Left < currentNPO.StartX + currentNPO.Steps)
                {
                    currentNPO.Left += velocity;
                }
                else
                {
                    currentNPO.Direct = (Direction.Cycling | Direction.Left);
                    currentNPO.StartX = currentNPO.Left;
                }
            }
            else if (currentNPO.Direct == (Direction.Up | Direction.Cycling))//moving up
            {
                if (currentNPO.Top > currentNPO.StartY - currentNPO.Steps)
                {
                    currentNPO.Top -= velocity;
                }
                else
                {
                    currentNPO.Direct = (Direction.Down | Direction.Cycling);
                    currentNPO.StartY = currentNPO.Top;
                }
            }
            else if (currentNPO.Direct == (Direction.Down | Direction.Cycling))//moving down 
            {
                if (currentNPO.Top < currentNPO.StartY + currentNPO.Steps)
                {
                    currentNPO.Top += velocity;
                }
                else
                {
                    currentNPO.Direct = (Direction.Up | Direction.Cycling);
                    currentNPO.StartY = currentNPO.Top;
                }
            }
        }

        private void PauseGame()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is PauseScreen)
                {
                    frm.Show();
                    return;
                }
            }
            timer3.Stop();
            PauseScreen pause = new PauseScreen(this);
            pause.Show();
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (db.Wasd)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        {
                            if (letMe)
                            {
                                playerIsMoving = true;
                                player.MovingRight();
                                right = true;
                                letMe = false;
                            }
                            break;
                        }
                    case Keys.A:
                        {
                            if (letMe)
                            {
                                playerIsMoving = true;
                                player.MovingLeft();
                                left = true;
                                letMe = false;
                            }
                            break;
                        }
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        {
                            if (letMe)
                            {
                                playerIsMoving = true;
                                player.MovingRight();
                                right = true;
                                letMe = false;
                            }
                            break;
                        }
                    case Keys.Left:
                        {
                            if (letMe)
                            {
                                playerIsMoving = true;
                                player.MovingLeft();
                                left = true;
                                letMe = false;
                            }
                            break;
                        }
                }
            }
            switch (e.KeyCode)
            {
                case Keys.P:
                    {
                        PauseGame();
                        break;
                    }

                case Keys.Space:
                    {
                        Jump();
                        break;
                    }
                case Keys.Escape:
                    {
                        PauseGame();
                        break;
                    }
                case Keys.F12:
                    {
                        NextLevel(); break;
                    }
            }
        }

        private void Level3_Activated(object sender, EventArgs e)
        {
            timer3.Start();
            if (Music.IsPlaying)
            {
                Music.Playlevel3();
            }
        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            if (db.Wasd)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        {
                            playerIsMoving = false;
                            right = false;
                            letMe = true;
                            player.IdleRight();
                            break;
                        }
                    case Keys.A:
                        {
                            playerIsMoving = false;
                            left = false;
                            letMe = true;
                            player.IdleLeft();
                            break;
                        }
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right:
                        {
                            playerIsMoving = false;
                            right = false;
                            letMe = true;
                            player.IdleRight();
                            break;
                        }
                    case Keys.Left:
                        {
                            playerIsMoving = false;
                            left = false;
                            letMe = true;
                            player.IdleLeft();
                            break;
                        }
                }
            }
        }

        private void RunGameOverScreen()
        {
            GameOverScreen gos = new GameOverScreen(this.db);
            Application.Run(gos);
        }

        private void InitializeMyComponenets()
        {
            //
            //archer floor
            //
            npo[0] = new NonPlayer(false, false, 0, Direction.None);
            npo[0].Location = new System.Drawing.Point(850, 373);
            npo[0].Name = "Archer_floor";
            npo[0].Size = new System.Drawing.Size(100, 50);
            npo[0].Visible = false;
            //
            // starting platfoorm
            //
            npo[1] = new NonPlayer(false, false, 0, Direction.None);
            npo[1].BackgroundImageLayout = ImageLayout.None;
            npo[1].Location = new System.Drawing.Point(0, 622);
            npo[1].Name = "starting_platform";
            npo[1].Size = new System.Drawing.Size(163, 118);
            npo[1].Visible = false;
            //
            //platform 1
            //
            npo[2] = new NonPlayer(false, false, 0, Direction.None);
            npo[2].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            npo[2].Location = new System.Drawing.Point(237, 470);
            npo[2].Name = "platform1";
            npo[2].Size = new System.Drawing.Size(159, 88);
            npo[2].Visible = false;
            //
            //platform 2
            //
            npo[3] = new NonPlayer(false, false, 0, Direction.None);
            npo[3].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            npo[3].Location = new System.Drawing.Point(-44, 420);
            npo[3].Name = "platform2";
            npo[3].Size = new System.Drawing.Size(168, 99);
            npo[3].Visible = false;
            //
            // platform 2.5
            //
            npo[4] = new NonPlayer(false, false, 0, Direction.None);
            npo[4].Size = new System.Drawing.Size(80, 60);
            npo[4].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            npo[4].BackColor = System.Drawing.Color.Transparent;
            npo[4].Location = new System.Drawing.Point(190, 576);
            npo[4].Name = "new_platfom";
            npo[4].Visible = false;
            //
            //platform 3
            //
            npo[5] = new NonPlayer(false, false, 0, Direction.None, () => AddPoints(5));
            npo[5].Location = new System.Drawing.Point(133, 291);
            npo[5].Name = "platform4";
            npo[5].Size = new System.Drawing.Size(164, 42);
            npo[5].Visible = false;
            //
            //enemy- spikes 1
            //
            npo[7] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[7].Location = new System.Drawing.Point(264, 248);
            npo[7].Name = "spike1";
            npo[7].Size = new System.Drawing.Size(163, 85);
            npo[7].Visible = false;
            //
            //platform 5
            //
            npo[8] = new NonPlayer(false, false, 0, Direction.None);
            npo[8].Location = new System.Drawing.Point(355, 215);
            npo[8].Name = "platform5";
            npo[8].Size = new System.Drawing.Size(147, 38);
            npo[8].Visible = false;
            //
            // moving platfrom 1
            //
            npo[10] = new NonPlayer(false, false, 400, (Direction.Up | Direction.Cycling));
            npo[10].BackColor = System.Drawing.Color.Transparent;
            npo[10].Image = global::TheSurvivor.Properties.Resources.plat3_3;
            npo[10].Location = new System.Drawing.Point(686, 600);
            npo[10].Name = "moving_platform2";
            npo[10].Size = new System.Drawing.Size(138, 37);
            npo[10].StartX = npo[10].Left;
            npo[10].StartY = npo[10].Top;
            //
            // moving platfrom 2 - enemy
            //
            npo[16] = new NonPlayer(true, false, 400, (Direction.Down | Direction.Cycling), LoseHP);
            npo[16].BackColor = System.Drawing.Color.Transparent;
            npo[16].Image = global::TheSurvivor.Properties.Resources.GreenSpike;
            npo[16].Location = new System.Drawing.Point(686 - 140, 200);
            npo[16].Name = "moving_platform2";
            npo[16].Size = new System.Drawing.Size(100, 50);
            npo[16].StartX = npo[16].Left;
            npo[16].StartY = npo[16].Top;
            npo[16].BringToFront();
            //
            // end platform
            //
            npo[11] = new NonPlayer(false, false, 0, Direction.None);
            npo[11].Location = new System.Drawing.Point(823, 667);
            npo[11].Name = "end_platform";
            npo[11].Size = new System.Drawing.Size(164, 73);
            npo[11].Visible = false;
            //
            // portal
            //
            npo[12] = new NonPlayer(false, true, 0, Direction.None, NextLevel);
            npo[12].Location = new System.Drawing.Point(909, 560);
            npo[12].Name = "portal";
            npo[12].Size = new System.Drawing.Size(88, 135);
            npo[12].Visible = false;
            //
            //enemy - spike 2
            //
            npo[13] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[13].Location = new System.Drawing.Point(658, 661);
            npo[13].Name = "spike2";
            npo[13].Size = new System.Drawing.Size(166, 79);
            npo[13].Visible = false;
            //
            // vine 1
            //
            npo[14] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[14].Location = new System.Drawing.Point(428, 248);
            npo[14].Name = "vine1";
            npo[14].Size = new System.Drawing.Size(52, 155);
            npo[14].Visible = false;
            //
            // vine 2
            //
            npo[15] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[15].Location = new System.Drawing.Point(835, 1);
            npo[15].Name = "vine2";
            npo[15].Size = new System.Drawing.Size(47, 157);
            npo[15].Visible = false;
            //
            //diamond 1
            //
            npo[6] = new NonPlayer(false, true, 0, Direction.None, () => AddPoints(6));
            npo[6].BackColor = System.Drawing.Color.Transparent;
            npo[6].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[6].Location = new System.Drawing.Point(133, 248);
            npo[6].Name = "diamond1";
            npo[6].Size = new System.Drawing.Size(50, 45);
            npo[6].SendToBack();
            //
            //diamond 2
            //
            npo[9] = new NonPlayer(false, true, 0, Direction.None, () => AddPoints(9));
            npo[9].BackColor = System.Drawing.Color.Transparent;
            npo[9].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[9].Location = new System.Drawing.Point(517, 416);
            npo[9].Name = "diamond2";
            npo[9].Size = new System.Drawing.Size(50, 45);
            npo[9].SendToBack();
            //
            //diamond 3
            //
            npo[17] = new NonPlayer(false, true, 0, Direction.None, () => AddPoints(17));
            npo[17].BackColor = System.Drawing.Color.Transparent;
            npo[17].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[17].Location = new System.Drawing.Point(551, 490);
            npo[17].Name = "diamond3";
            npo[17].Size = new System.Drawing.Size(50, 45);
            npo[17].SendToBack();
            //
            //diamond 4
            //
            npo[18] = new NonPlayer(false, true, 0, Direction.None, () => AddPoints(18));
            npo[18].BackColor = System.Drawing.Color.Transparent;
            npo[18].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[18].Location = new System.Drawing.Point(722, 300);
            npo[18].Name = "diamond4";
            npo[18].Size = new System.Drawing.Size(50, 45);
            npo[18].SendToBack();
            //
            // diamond 5
            //
            npo[19] = new NonPlayer(false, true, 0, Direction.None, () => AddPoints(19));
            npo[19].BackColor = System.Drawing.Color.Transparent;
            npo[19].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[19].Location = new System.Drawing.Point(937, 481);
            npo[19].Name = "diamond5";
            npo[19].Size = new System.Drawing.Size(50, 50);
            //
            //enemy - floor 1
            //
            npo[20] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[20].BackColor = System.Drawing.Color.Transparent;
            npo[20].Location = new System.Drawing.Point(486, 661);
            npo[20].Name = "pictureBox1";
            npo[20].Size = new System.Drawing.Size(166, 79);
            npo[20].Visible = false;
            //
            //enemy - floor 2
            //
            npo[21] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[21].Location = new System.Drawing.Point(314, 661);
            npo[21].Name = "pictureBox2";
            npo[21].Size = new System.Drawing.Size(166, 79);
            npo[21].Visible = false;
            //
            //enemy - floor 3
            //
            npo[22] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[22].Location = new System.Drawing.Point(142, 661);
            npo[22].Name = "pictureBox3";
            npo[22].Size = new System.Drawing.Size(166, 79);
            npo[22].Visible = false;
            //
            //enemy - floor 4
            //
            npo[23] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[23].Location = new System.Drawing.Point(814, 622);
            npo[23].Name = "pictureBox4";
            npo[23].Size = new System.Drawing.Size(52, 56);
            npo[23].Visible = false;
            //
            //enemy - knight
            //
            npo[24] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[24].BackColor = System.Drawing.Color.Transparent;
            npo[24].Image = global::TheSurvivor.Properties.Resources.enemy_knight;
            npo[24].Location = new System.Drawing.Point(850, 255);
            npo[24].Name = "archer";
            npo[24].Size = new System.Drawing.Size(107, 128);
            //
            //plyaer
            //
            player = new Player(respawn, velocity + 1);
            player.BringToFront();
            player.BackColor = System.Drawing.Color.Transparent;
            player.Image = global::TheSurvivor.Properties.Resources.IdleRightSmall;
            player.Location = new System.Drawing.Point(51, 550);
            player.Name = "player";
            player.Size = new System.Drawing.Size(30, 50);
            player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            foreach (NonPlayer n in npo)
            {
                this.Controls.Add(n);
            }

            this.Controls.Add(player);
        }

        private void AddPoints(int i)
        {
            db.Score += 100;
            Controls.Remove(npo[i]);
            npo[i] = null;
            ScorePoints.Text = db.Score.ToString();
        }
    }
}

