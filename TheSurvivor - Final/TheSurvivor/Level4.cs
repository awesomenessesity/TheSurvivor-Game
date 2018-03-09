using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TheSurvivor
{
    public partial class Level4 : GameForm
    {
        private Size[] npSizes = { new Size(85, 18), new Size(29, 18), new Size(40, 20), new Size(27, 27) }; //an array of repatedly used sizes
        private NonPlayer[] npo = new NonPlayer[50]; //creating an npo array
        private Player player; //creating player
        private Point respawn = new Point(50, 670);  //creating a respawn point for the player
        private int velocity = 3;
        private bool letMe = true, right, left, up, down, canClimb; //to know state of player
        private bool l, u, d; //to know if was on moving blocks that moves that way (up , down, left)
        private int c;

        public Level4(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            hpBar.Increment(db.Life);
            score.Text = ("Score " + db.Score.ToString());
            score.SendToBack();
            if (Music.IsPlaying)
            {
                Music.Playlevel4();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameUpdate(); //each timer tick calling the update function
        }

        private void Level4_Load(object sender, EventArgs e) //when the form loads creates evrything(needed because using Drawing)
        {
            this.npo[0] = new NonPlayer(false, false, 0, 0);
            this.npo[0].Size = new System.Drawing.Size(108, 56);
            this.npo[0].Location = new System.Drawing.Point(0, this.Bottom - npo[0].Height - 12);
            this.npo[0].Image = global::TheSurvivor.Properties.Resources.StartBlock;
            //
            //
            this.npo[1] = new NonPlayer(false, false, 0, 0);
            this.npo[1].Size = new System.Drawing.Size(57, 18);
            this.npo[1].Location = new System.Drawing.Point(50, 390);
            this.npo[1].Image = global::TheSurvivor.Properties.Resources.npo_0_;
            //
            //
            this.npo[2] = new NonPlayer(false, false, 0, 0);
            this.npo[2].Size = npSizes[0];
            this.npo[2].Location = new System.Drawing.Point(140, 315);
            //
            //
            this.npo[3] = new NonPlayer(false, false, 0, 0);
            this.npo[3].Size = npSizes[0];
            this.npo[3].Location = new System.Drawing.Point(288, 295);
            //
            //
            this.npo[4] = new NonPlayer(false, false, 0, 0);
            this.npo[4].Size = npSizes[0];
            this.npo[4].Location = new System.Drawing.Point(430, 479);
            //
            //
            this.npo[5] = new NonPlayer(false, false, 0, 0);
            this.npo[5].Size = npSizes[0];
            this.npo[5].Location = new System.Drawing.Point(550, 426);
            //
            //
            this.npo[6] = new NonPlayer(false, false, 0, 0);
            this.npo[6].Size = npSizes[0];
            this.npo[6].Location = new System.Drawing.Point(0, 205);
            //
            //
            this.npo[7] = new NonPlayer(false, false, 0, 0);
            this.npo[7].Size = npSizes[0];
            this.npo[7].Location = new System.Drawing.Point(295, 139);
            //
            //
            this.npo[8] = new NonPlayer(false, false, 0, 0);
            this.npo[8].Size = npSizes[0];
            this.npo[8].Location = new System.Drawing.Point(440, 170);
            //
            //
            this.npo[9] = new NonPlayer(false, false, 0, 0);
            this.npo[9].Size = npSizes[0];
            this.npo[9].Location = new System.Drawing.Point(579, 128);
            //
            //
            this.npo[10] = new NonPlayer(false, false, 0, 0); // has the npo of move to GameOver on it
            this.npo[10].Size = npSizes[0];
            this.npo[10].Location = new System.Drawing.Point(this.Width - npo[10].Width, 258);
            //
            //
            this.npo[11] = new NonPlayer(false, false, 0, 0);
            this.npo[11].Size = npSizes[0];
            this.npo[11].Location = new System.Drawing.Point(0, 77);
            //
            ///////small ones/////
            //
            this.npo[12] = new NonPlayer(false, false, 0, 0);
            this.npo[12].Size = npSizes[1];
            this.npo[12].Location = new System.Drawing.Point(680, 451);
            //
            //
            this.npo[13] = new NonPlayer(false, false, 0, 0);
            this.npo[13].Size = npSizes[1];
            this.npo[13].Location = new System.Drawing.Point(733, 477);
            //
            //
            this.npo[14] = new NonPlayer(false, false, 0, 0);
            this.npo[14].Size = npSizes[1];
            this.npo[14].Location = new System.Drawing.Point(127, 160);
            //
            //
            this.npo[15] = new NonPlayer(false, false, 0, 0);
            this.npo[15].Size = npSizes[1];
            this.npo[15].Location = new System.Drawing.Point(158, 123);
            //
            //
            this.npo[16] = new NonPlayer(false, false, 0, 0);
            this.npo[16].Size = npSizes[1];
            this.npo[16].Location = new System.Drawing.Point(196, 139);
            //
            //
            this.npo[17] = new NonPlayer(false, false, 0, 0);
            this.npo[17].Size = npSizes[1];
            this.npo[17].Location = new System.Drawing.Point(242, 159);
            //
            //
            this.npo[18] = new NonPlayer(false, false, 0, 0);
            this.npo[18].Size = npSizes[1];
            this.npo[18].Location = new System.Drawing.Point(398, 140);
            //
            //
            this.npo[19] = new NonPlayer(false, false, 0, 0);
            this.npo[19].Size = npSizes[1];
            this.npo[19].Location = new System.Drawing.Point(635, 268);
            //
            //
            this.npo[20] = new NonPlayer(false, false, 0, 0);
            this.npo[20].Size = npSizes[1];
            this.npo[20].Location = new System.Drawing.Point(690, 221);
            //
            //
            this.npo[21] = new NonPlayer(false, false, 0, 0);//affected by trap
            this.npo[21].Size = npSizes[1];
            this.npo[21].Location = new System.Drawing.Point(123, 58);
            //
            //
            this.npo[22] = new NonPlayer(false, false, 0, 0);
            this.npo[22].Size = npSizes[1];
            this.npo[22].Location = new System.Drawing.Point(905, 40);
            //
            ///////////////Wall////////////////////////
            //
            this.npo[23] = new NonPlayer(false, false, 0, 0);
            this.npo[23].Size = new System.Drawing.Size(21, 287);
            this.npo[23].Location = new System.Drawing.Point(752, 0);
            //
            ////////////Moving Platform////////////////
            //
            this.npo[24] = new NonPlayer(false, true, 3, Direction.Down, moveD);//moves down
            this.npo[24].Size = npSizes[0];
            this.npo[24].Location = new System.Drawing.Point(263, 400);
            //
            //
            this.npo[25] = new NonPlayer(false, true, 3, Direction.Left, moveL);//moves left
            this.npo[25].Size = npSizes[0];
            this.npo[25].Location = new System.Drawing.Point(453, 679);
            //
            //
            this.npo[26] = new NonPlayer(false, true, 3, Direction.Up, moveU);//moves up
            this.npo[26].Size = npSizes[1];
            this.npo[26].Location = new System.Drawing.Point(795, 656);
            //
            ////////////////Ladders////////////////////27-31
            //
            this.npo[27] = new NonPlayer(false, true, 0, Direction.None, CanClimb);
            this.npo[27].Size = new System.Drawing.Size(9, npo[0].Top - npo[1].Bottom);
            this.npo[27].Location = new System.Drawing.Point(npo[0].Left + npo[27].Width / 2, npo[1].Bottom);
            //
            //
            this.npo[28] = new NonPlayer(false, true, 0, Direction.None, CanClimb);
            this.npo[28].BackColor = System.Drawing.SystemColors.WindowText;
            this.npo[28].Size = new System.Drawing.Size(9, npo[0].Top - npo[4].Bottom - 20);
            this.npo[28].Location = new System.Drawing.Point(npo[4].Left - npo[28].Width, npo[4].Bottom);
            //
            //
            this.npo[29] = new NonPlayer(false, true, 0, Direction.None, CanClimb);
            this.npo[29].BackColor = System.Drawing.SystemColors.WindowText;
            this.npo[29].Size = new System.Drawing.Size(9, npo[5].Top - npo[19].Bottom);
            this.npo[29].Location = new System.Drawing.Point(npo[5].Left + npo[5].Width / 4, npo[5].Top - npo[29].Height);
            //
            //
            this.npo[30] = new NonPlayer(false, true, 0, Direction.None, CanClimb);
            this.npo[30].BackColor = System.Drawing.SystemColors.WindowText;
            this.npo[30].Size = new System.Drawing.Size(9, npo[15].Top);
            this.npo[30].Location = new System.Drawing.Point(npo[15].Left, 0);
            //
            //
            this.npo[31] = new NonPlayer(false, true, 0, Direction.None, CanClimb);
            this.npo[31].BackColor = System.Drawing.SystemColors.WindowText;
            this.npo[31].Size = new System.Drawing.Size(9, npo[20].Top * 3 / 4);
            this.npo[31].Location = new System.Drawing.Point(npo[20].Left, npo[20].Top - npo[31].Height);
            //
            ///////////////////Spikes//////////////////
            //
            this.npo[32] = new NonPlayer(true, false, 0, 0, LoseHP);
            this.npo[32].Size = npSizes[2];
            this.npo[32].Location = new System.Drawing.Point(npo[7].Left + npo[7].Width / 4, npo[7].Top - npo[32].Height);
            //
            //
            this.npo[33] = new NonPlayer(true, false, 0, 0, LoseHP);
            this.npo[33].Size = npSizes[2];
            this.npo[33].Location = new System.Drawing.Point(npo[11].Left, npo[11].Top - npo[33].Height);
            //
            //
            this.npo[34] = new NonPlayer(true, false, 0, 0, LoseHP);
            this.npo[34].Size = new System.Drawing.Size(150, 20);
            this.npo[34].Location = new System.Drawing.Point(npo[23].Right, 0);
            this.npo[34].Image = global::TheSurvivor.Properties.Resources.longEnemy;
            //
            ///////////npo that moves player to GameOver//////////////
            //
            this.npo[35] = new NonPlayer(false, true, 0, 0, goToGameOver);
            this.npo[35].Size = new System.Drawing.Size(50, 100);
            this.npo[35].Location = new System.Drawing.Point(npo[10].Left, npo[10].Top - npo[35].Height);
            this.npo[35].Image = global::TheSurvivor.Properties.Resources.FirePrincess;
            this.npo[35].Click += new System.EventHandler(Princess_Click);
            this.npo[35].Cursor = System.Windows.Forms.Cursors.Hand;
            //
            ////////////////////points npo////////////////////////////
            //
            this.npo[36] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[36].Size = npSizes[3];
            this.npo[36].Location = new System.Drawing.Point(npo[27].Left, npo[27].Top);
            //
            //
            this.npo[37] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[37].Size = npSizes[3];
            this.npo[37].Location = new System.Drawing.Point(npo[28].Left, npo[28].Top);
            //
            //
            this.npo[38] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[38].Size = npSizes[3];
            this.npo[38].Location = new System.Drawing.Point(npo[29].Left + 3, npo[29].Top - 10);
            //
            //
            this.npo[39] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[39].Size = npSizes[3];
            this.npo[39].Location = new System.Drawing.Point(npo[30].Left + 11, npo[30].Top + 20);
            //
            //
            this.npo[40] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[40].Size = npSizes[3];
            this.npo[40].Location = new System.Drawing.Point(npo[31].Left - 7, npo[31].Top - 5);
            //
            //
            this.npo[41] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[41].Size = npSizes[3];
            this.npo[41].Location = new System.Drawing.Point(npo[6].Left + 7, npo[6].Top - 40);
            //
            //
            this.npo[42] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[42].Size = npSizes[3];
            this.npo[42].Location = new System.Drawing.Point(npo[24].Left + npo[24].Width / 2, npo[24].Bottom + 50);
            //
            //
            this.npo[43] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[43].Size = npSizes[3];
            this.npo[43].Location = new System.Drawing.Point(npo[24].Left + npo[24].Width / 2, npo[24].Bottom + 130);
            //
            //
            this.npo[44] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[44].Size = npSizes[3];
            this.npo[44].Location = new System.Drawing.Point(npo[24].Left + npo[24].Width / 2, npo[24].Bottom + 270);
            //
            //
            this.npo[45] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[45].Size = npSizes[3];
            this.npo[45].Location = new System.Drawing.Point(npo[26].Left + npo[26].Width / 2, npo[26].Top - 70);
            //
            //
            this.npo[46] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[46].Size = npSizes[3];
            this.npo[46].Location = new System.Drawing.Point(npo[26].Left + npo[26].Width / 2, npo[26].Top - 370);
            //
            //
            this.npo[47] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[47].Size = npSizes[3];
            this.npo[47].Location = new System.Drawing.Point(npo[26].Left + npo[26].Width / 2, 100);
            //
            //
            this.npo[48] = new NonPlayer(false, true, 0, 0, AddPoints);
            this.npo[48].Size = npSizes[3];
            this.npo[48].Location = new System.Drawing.Point(npo[26].Left + npo[26].Width, 130);
            //
            //////////////////Trap Transparent/////////////////////////////
            //
            this.npo[49] = new NonPlayer(false, true, 0, 0, Trap);
            this.npo[49].Size = new System.Drawing.Size(5, npo[32].Bottom);
            this.npo[49].Location = new System.Drawing.Point(npo[32].Left + npo[32].Width / 2, 0);

            foreach (NonPlayer n in npo)
            {
                if (n != null)
                {
                    n.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    n.BackColor = System.Drawing.Color.Transparent;
                    this.Controls.Add(n);
                    if (n.Size == npSizes[0])
                    {
                        n.Image = global::TheSurvivor.Properties.Resources.npo_0_;
                    }
                    else if (n.Size == npSizes[1])
                    {
                        n.Image = global::TheSurvivor.Properties.Resources.npo_1_;
                    }
                    else if (n.Size == npSizes[2])
                    {
                        n.Image = global::TheSurvivor.Properties.Resources.npo_2_;
                    }
                    else if (n.wtd == AddPoints)
                    {
                        n.Image = global::TheSurvivor.Properties.Resources.Gem;
                        n.BringToFront();
                    }
                }
            }
            //
            ////////////////////player//////////////////////
            //
            player = new Player(respawn, velocity);
            this.player.Size = new System.Drawing.Size(30, 50);
            this.player.Location = new System.Drawing.Point(50, npo[0].Top - 50);
            player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            player.BackColor = System.Drawing.Color.Transparent;
            player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif;
            this.Controls.Add(this.player);
        }

        private void Level4_KeyDown(object sender, KeyEventArgs e)
        {
            if (db.Wasd)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        {
                            if (letMe)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.RunRightSmall;
                                right = true;
                                letMe = false;
                            }
                            break;
                        }
                    case Keys.A:
                        {
                            if (letMe)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.RunLeftSmall;
                                left = true;
                                letMe = false;
                            }

                            break;
                        }
                    case Keys.W:
                        {
                            if (canClimb)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif;
                                up = true;
                            }

                            break;
                        }
                    case Keys.S:
                        {
                            if (canClimb)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif;
                                down = true;
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
                                player.Image = global::TheSurvivor.Properties.Resources.RunRightSmall;
                                right = true;
                                letMe = false;
                            }
                            break;
                        }
                    case Keys.Left:
                        {
                            if (letMe)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.RunLeftSmall;
                                left = true;
                                letMe = false;
                            }

                            break;
                        }
                    case Keys.Up:
                        {
                            if (canClimb)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif;
                                up = true;
                            }

                            break;
                        }
                    case Keys.Down:
                        {
                            if (canClimb)
                            {
                                player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif;
                                down = true;
                            }
                            break;
                        }
                }
            }
            switch (e.KeyCode)
            {
                case Keys.P: { GamePause(); break; }
                case Keys.Space: { playerJump(); break; }
                case Keys.Escape: { GamePause(); break; }
                case Keys.F12: { goToGameOver(); break; }
            }
        }

        private void Level4_KeyUp(object sender, KeyEventArgs e)
        {
            if (db.Wasd)
            {
                switch (e.KeyCode)
                {
                    case Keys.D: { canClimb = false; right = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                    case Keys.A: { canClimb = false; left = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                    case Keys.S: { canClimb = false; down = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                    case Keys.W: { canClimb = false; up = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.Right: { canClimb = false; right = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                    case Keys.Left: { canClimb = false; left = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                    case Keys.Down: { canClimb = false; down = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                    case Keys.Up: { canClimb = false; up = false; letMe = true; player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif; break; }
                }
            }
        }

        private void gameUpdate()
        {
            player.Top += (int)player.Gravity;
            if (player.Gravity < 5)
            {
                player.Gravity += 0.68f;
            }

            if (right && !left)
            {
                MoveRight();
            }
            if (left && !right)
            {
                MoveLeft();
            }
            if (down && !up)
            {
                MoveDown();
            } //up false to prvent glitching
            if (up && !down)
            {
                MoveUp();
            } //down false to prvent glitching

            if (player.Bottom >= this.Bottom)
            {
                LoseHP();
                player.Location = respawn;
            }
            if (player.Right >= dragonWind.Left && player.Top <= npo[35].Bottom && player.Left <= dragonWind.Right)
            {
                player.Top += 20; //when player enters the Life label area he moves down quickt to make the jump impossible
            }
            if (player.Left <= this.Left && player.Bottom <= npo[11].Bottom)
            {
                player.Left = this.Right; //"teleports" the player to other side of game screen
            }
            else if (player.Left <= this.Left - 10 && player.Bottom >= npo[11].Bottom)
            {
                player.Left = this.Left; //makes sure the player won't pass the game screen from the left side
            }

            MoveNPO();  //check and calls the movment of all moving blocks
            player.Collision(npo); //checking if player had collison with any npo
            player.BringToFront(); //puts the image of player in front of all other picture box 
        }

        private void MoveRight()
        {
            player.Left += player.Velocity;
        }

        private void MoveLeft()
        {
            player.Left -= player.Velocity;
        }

        private void MoveUp()
        {
            player.Top -= player.Velocity;
        }

        private void MoveDown()
        {
            player.Top += player.Velocity;
        }

        private void playerJump()
        {
            if (up || down) { }
            else if (player.Jump)
            {
                player.Gravity -= 12f;
                up = false;
                player.Jump = false;
            }
        }

        private void Princess_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stop clicking me and start saving me!");
        }

        private void moveD()  //when on moving down block
        {
            player.Jump = true;
            d = true;       //so he wil know the player was on the block
            player.Gravity = 0;  //to make the movement more smooth and jumping easier
            player.Top = npo[24].Top - player.Height;  //so the player stay on the npo
            player.Top += velocity + 3;  //so the player moves with the npo
        }

        private void moveL()
        {
            player.Jump = true;
            l = true; //so he wil know the player was on the block
            player.Gravity = 0; //to make the movement more smooth and jumping easier
            player.Top = npo[25].Top - player.Height; //so the player stay on the npo
            player.Left += velocity + 3; //so the player moves with the npo
        }

        private void moveU()
        {
            player.Jump = true;
            u = true; //so he wil know the player was on the block
            player.Gravity = 0; //to make the movement more smooth and jumping easier
            player.Top = npo[26].Top - player.Height; //so the player stay on the npo
            player.Top -= velocity + 3; //so the player moves with the npo
        }

        private void MoveNPO()
        {
            if (d)//after player was on the block will keep moving down 
            {
                npo[24].Top += velocity;
            }
            if (l) //after player was on the block will keep moving left
            {
                npo[25].Left += velocity;
            }
            if (u)//after player was on the block will keep moving up
            {
                npo[26].Top -= velocity;
            }
        }

        private void resetNpo() //reset the moving blocks to their starting condition
        {
            npo[24].Location = new Point(263, 400);
            npo[25].Location = new Point(453, 679);
            npo[26].Location = new Point(795, 656);
            l = false;
            u = false;
            d = false;
        }

        private void LoseHP()//sent by droping down screen or spikes npo[32--34]
        {
            c++;
            this.db.Life--;
            resetNpo();
            hpBar.Increment(-1);
            ChangeHpBarColor();

            if (this.db.Life == 0)
            {
                goToGameOver();
            }
            if (c == 3)
            {
                ChangeSpikes();
            }
        }

        private void ChangeSpikes()
        {
            npo[32].Image = global::TheSurvivor.Properties.Resources.npo_2_Blood;
            npo[33].Image = global::TheSurvivor.Properties.Resources.npo_2_Blood;
            npo[34].Image = global::TheSurvivor.Properties.Resources.longEnemyBlood;
        }

        private void CanClimb()
        {
            canClimb = true;
            player.Gravity = 0;
            player.Jump = true;
        }

        private void AddPoints()//(int i)
        {
            for (int i = 36; i < npo.Length; i++)
            {
                if (npo[i] == null) { }
                else if (player.PointInShape(npo[i]))
                {
                    Controls.Remove(npo[i]);
                    npo[i] = null;
                    db.Score += 100;
                    score.Text = ("Score " + db.Score.ToString());
                }
            }
        }

        private void goToGameOver()
        {
            timer1.Stop();
            Thread tr = new Thread(RunGameOverScreen);
            tr.Start();
            this.Close();
        }

        private void RunGameOverScreen()
        {
            this.db.Score += this.db.Life * 200;
            GameOverScreen gos = new GameOverScreen(db);
            Application.Run(gos);
        }

        private void GamePause()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is PauseScreen)
                {
                    frm.Show();
                    return;
                }
            }
            PauseScreen pause = new PauseScreen(this);
            timer1.Stop();
            pause.Show();
        }

        private void Trap()//removes npo when activated npo[3,4,9,12,14,16,17,18,19,21]
        {
            ChangeSpikes();
            int[] ind = { 3, 4, 9, 12, 14, 16, 17, 18, 19, 21 };
            for (int i = 0, j = 0; i < npo.Length; i++)
            {
                if (npo[i] == null) { }
                else if (j < ind.Length && i == ind[j])
                {
                    Controls.Remove(npo[i]); npo[i] = null;
                    j++;
                    //  Controls.Remove(npo[21]); npo[21] = null;
                }
                else if (npo[i].wtd == Trap)
                {
                    Controls.Remove(npo[i]); npo[i] = null;
                }
            }
        }

        private void ChangeHpBarColor()
        {
            if (db.Life < 7)
            {
                hpBar.ForeColor = Color.Crimson;
            }
            else if (db.Life < 11)
            {
                hpBar.ForeColor = Color.OrangeRed;
            }
            else
            {
                hpBar.ForeColor = Color.Tomato;
            }
        }

        private void Level4_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            if (Music.IsPlaying)
            {
                Music.Playlevel4();
            }
        }
    }
}
