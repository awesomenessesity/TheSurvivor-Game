using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TheSurvivor
{
    public partial class Level2 : GameForm
    {
        NonPlayer[] npo = new NonPlayer[44];
        NonPlayer ladder1, ladder2, ladder3, ladder4;
        Player player;
        Point respawn = new Point(10, 691);
        int velocity = 2;
        bool canClimb = false, playerIsMoving = false;
        bool right = false, left = false, up = false, down = false, letMe = true;

        public Level2(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            InitializeMyComponenets();
            this.FormBorderStyle = FormBorderStyle.None;
            timer1.Start();
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
               
                Music.Playlevel2();
            }
        }

        private void InitializeMyComponenets()
        {
            //player
            player = new Player(respawn, 5);
            //floors
            npo[0] = new NonPlayer(false, false, 0, Direction.None);
            npo[1] = new NonPlayer(false, false, 0, Direction.None);
            npo[2] = new NonPlayer(false, false, 0, Direction.None);
            npo[3] = new NonPlayer(false, false, 0, Direction.None);
            npo[4] = new NonPlayer(false, false, 0, Direction.None);
            npo[5] = new NonPlayer(false, false, 0, Direction.None);
            npo[6] = new NonPlayer(false, false, 0, Direction.None);
            npo[7] = new NonPlayer(false, false, 0, Direction.None);
            npo[8] = new NonPlayer(false, false, 0, Direction.None);
            npo[9] = new NonPlayer(false, false, 0, Direction.None);
            npo[10] = new NonPlayer(false, false, 0, Direction.None);
            npo[11] = new NonPlayer(false, false, 0, Direction.None);
            npo[12] = new NonPlayer(false, false, 0, Direction.None);
            npo[13] = new NonPlayer(false, false, 0, Direction.None);
            npo[14] = new NonPlayer(false, false, 0, Direction.None);
            npo[15] = new NonPlayer(false, false, 0, Direction.None);
            npo[16] = new NonPlayer(false, false, 0, Direction.None);
            npo[17] = new NonPlayer(false, false, 0, Direction.None);
            npo[18] = new NonPlayer(false, false, 0, Direction.None);
            //enemies
            npo[19] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[20] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[21] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[22] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[23] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[24] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[25] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[26] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[27] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[28] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            npo[29] = new NonPlayer(true, false, 0, Direction.None, LoseHP);
            //diamonds
            npo[30] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsSpecial(30));//red
            npo[31] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsBlue(31));
            npo[32] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsRed(32));//red
            npo[33] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsBlue(33));
            npo[34] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsBlue(34));
            npo[35] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsBlue(35));
            npo[36] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsRed(36));//red
            //moving floors
            npo[37] = new NonPlayer(false, false, 140, (Direction.Right | Direction.Cycling));
            npo[38] = new NonPlayer(false, false, 170, (Direction.Down | Direction.Cycling));
            npo[39] = new NonPlayer(false, false, 370, (Direction.Left | Direction.Cycling));
            //moving enemy
            npo[40] = new NonPlayer(true, false, 100, (Direction.Down | Direction.Cycling), LoseHP);
            npo[41] = new NonPlayer(true, false, 80, (Direction.Up | Direction.Cycling), LoseHP);
            npo[42] = new NonPlayer(true, false, 80, (Direction.Down | Direction.Cycling), LoseHP);
            //portal
            npo[43] = new NonPlayer(false, true, 0, Direction.None, NextLevel);
            //ladders
            ladder1 = new NonPlayer(false, true, 0, Direction.None);
            ladder2 = new NonPlayer(false, true, 0, Direction.None);
            ladder3 = new NonPlayer(false, true, 0, Direction.None);
            ladder4 = new NonPlayer(false, true, 0, Direction.None);
            // 
            // floor1
            // 
            npo[0].BackColor = System.Drawing.Color.Transparent;
            npo[0].Location = new System.Drawing.Point(-1, 741);
            npo[0].Name = "floor1";
            npo[0].Size = new System.Drawing.Size(154, 27);
            // 
            // floor2
            // 
            npo[1].BackColor = System.Drawing.Color.Transparent;
            npo[1].Location = new System.Drawing.Point(227, 742);
            npo[1].Name = "floor2";
            npo[1].Size = new System.Drawing.Size(161, 26);
            // 
            // floor3
            // 
            npo[2].BackColor = System.Drawing.Color.Transparent;
            npo[2].Location = new System.Drawing.Point(607, 741);
            npo[2].Name = "floor3";
            npo[2].Size = new System.Drawing.Size(159, 27);
            //
            // floor4
            // 
            npo[3].BackColor = System.Drawing.Color.Transparent;
            npo[3].Location = new System.Drawing.Point(804, 683);
            npo[3].Name = "floor4";
            npo[3].Size = new System.Drawing.Size(36, 30);
            // 
            // floor5
            // 
            npo[4].BackColor = System.Drawing.Color.Transparent;
            npo[4].Location = new System.Drawing.Point(915, 742);
            npo[4].Name = "floor5";
            npo[4].Size = new System.Drawing.Size(109, 26);
            // 
            // floor6
            // 
            npo[5].BackColor = System.Drawing.Color.Transparent;
            npo[5].Location = new System.Drawing.Point(844, 523);
            npo[5].Name = "floor6";
            npo[5].Size = new System.Drawing.Size(136, 36);
            // 
            // floor7
            // 
            npo[6].BackColor = System.Drawing.Color.Transparent;
            npo[6].Location = new System.Drawing.Point(881, 403);
            npo[6].Name = "floor7";
            npo[6].Size = new System.Drawing.Size(143, 26);
            // 
            // floor8
            // 
            npo[7].BackColor = System.Drawing.Color.Transparent;
            npo[7].Location = new System.Drawing.Point(852, 320);
            npo[7].Name = "floor8";
            npo[7].Size = new System.Drawing.Size(59, 29);
            // 
            // floor9
            // 
            npo[8].BackColor = System.Drawing.Color.Transparent;
            npo[8].Location = new System.Drawing.Point(552, 495);
            npo[8].Name = "floor9";
            npo[8].Size = new System.Drawing.Size(74, 30);
            // 
            // floor10
            // 
            npo[9].BackColor = System.Drawing.Color.Transparent;
            npo[9].Location = new System.Drawing.Point(345, 495);
            npo[9].Name = "floor10";
            npo[9].Size = new System.Drawing.Size(132, 29);
            // 
            // floor11
            // 
            npo[10].BackColor = System.Drawing.Color.Transparent;
            npo[10].Location = new System.Drawing.Point(50, 494);
            npo[10].Name = "floor11";
            npo[10].Size = new System.Drawing.Size(238, 28);
            // 
            // floor12
            // 
            npo[11].BackColor = System.Drawing.Color.Transparent;
            npo[11].Location = new System.Drawing.Point(82, 334);
            npo[11].Name = "floor12";
            npo[11].Size = new System.Drawing.Size(193, 28);
            // 
            // floor13
            // 
            npo[12].BackColor = System.Drawing.Color.Transparent;
            npo[12].Location = new System.Drawing.Point(354, 333);
            npo[12].Name = "floor13";
            npo[12].Size = new System.Drawing.Size(217, 30);
            // 
            // floor14
            // 
            npo[13].BackColor = System.Drawing.Color.Transparent;
            npo[13].Location = new System.Drawing.Point(-1, 154);
            npo[13].Name = "floor14";
            npo[13].Size = new System.Drawing.Size(63, 29);
            // 
            // floor15
            // 
            npo[14].BackColor = System.Drawing.Color.Transparent;
            npo[14].Location = new System.Drawing.Point(100, 85);
            npo[14].Name = "floor15";
            npo[14].Size = new System.Drawing.Size(64, 28);
            // 
            // floor16
            // 
            npo[15].BackColor = System.Drawing.Color.Transparent;
            npo[15].Location = new System.Drawing.Point(218, 71);
            npo[15].Name = "floor16";
            npo[15].Size = new System.Drawing.Size(148, 31);
            // 
            // floor17
            // 
            npo[16].BackColor = System.Drawing.Color.Transparent;
            npo[16].Location = new System.Drawing.Point(451, 71);
            npo[16].Name = "floor17";
            npo[16].Size = new System.Drawing.Size(84, 31);
            // 
            // floor18
            // 
            npo[17].BackColor = System.Drawing.Color.Transparent;
            npo[17].Location = new System.Drawing.Point(566, 127);
            npo[17].Name = "floor18";
            npo[17].Size = new System.Drawing.Size(139, 28);
            // 
            // floor19
            // 
            npo[18].BackColor = System.Drawing.Color.Transparent;
            npo[18].Location = new System.Drawing.Point(784, 151);
            npo[18].Name = "floor19";
            npo[18].Size = new System.Drawing.Size(243, 35);
            // 
            // enemy1
            // 
            npo[19].BackColor = System.Drawing.Color.Transparent;
            npo[19].Location = new System.Drawing.Point(166, 704);
            npo[19].Name = "enemy1";
            npo[19].Size = new System.Drawing.Size(54, 64);
            // 
            // enemy2
            // 
            npo[20].BackColor = System.Drawing.Color.Transparent;
            npo[20].Location = new System.Drawing.Point(400, 704);
            npo[20].Name = "enemy2";
            npo[20].Size = new System.Drawing.Size(196, 64);
            // 
            // enemy3
            // 
            npo[21].BackColor = System.Drawing.Color.Transparent;
            npo[21].Location = new System.Drawing.Point(777, 704);
            npo[21].Name = "enemy3";
            npo[21].Size = new System.Drawing.Size(128, 64);
            // 
            // enemy4
            // 
            npo[22].BackColor = System.Drawing.Color.Transparent;
            npo[22].Location = new System.Drawing.Point(777, 314);
            npo[22].Name = "enemy4";
            npo[22].Size = new System.Drawing.Size(54, 216);
            // 
            // enemy5
            // 
            npo[23].BackColor = System.Drawing.Color.Transparent;
            npo[23].Location = new System.Drawing.Point(720, 364);
            npo[23].Name = "enemy5";
            npo[23].Size = new System.Drawing.Size(53, 44);
            // 
            // enemy6
            // 
            npo[24].BackColor = System.Drawing.Color.Transparent;
            npo[24].Location = new System.Drawing.Point(582, 243);
            npo[24].Name = "enemy6";
            npo[24].Size = new System.Drawing.Size(50, 153);
            // 
            // enemy7
            // 
            npo[25].BackColor = System.Drawing.Color.Transparent;
            npo[25].Location = new System.Drawing.Point(191, 192);
            npo[25].Name = "enemy7";
            npo[25].Size = new System.Drawing.Size(51, 44);
            // 
            // enemy8
            // 
            npo[26].BackColor = System.Drawing.Color.Transparent;
            npo[26].Location = new System.Drawing.Point(-1, 37);
            npo[26].Name = "enemy8";
            npo[26].Size = new System.Drawing.Size(41, 58);
            // 
            // enemy9
            // 
            npo[27].BackColor = System.Drawing.Color.Transparent;
            npo[27].Location = new System.Drawing.Point(596, -2);
            npo[27].Name = "enemy9";
            npo[27].Size = new System.Drawing.Size(48, 76);
            // 
            // enemy10
            // 
            npo[28].BackColor = System.Drawing.Color.Transparent;
            npo[28].Location = new System.Drawing.Point(719, 106);
            npo[28].Name = "enemy10";
            npo[28].Size = new System.Drawing.Size(50, 100);
            // 
            // enemy11
            // 
            npo[29].BackColor = System.Drawing.Color.Transparent;
            npo[29].Location = new System.Drawing.Point(826, 0);
            npo[29].Name = "enemy11";
            npo[29].Size = new System.Drawing.Size(58, 95);
            // 
            // diamond1red
            // 
            npo[30].BackColor = System.Drawing.Color.Transparent;
            npo[30].Image = global::TheSurvivor.Properties.Resources.DiamondRed;
            npo[30].Location = new System.Drawing.Point(8, 533);
            npo[30].Name = "diamond1red";
            npo[30].Size = new System.Drawing.Size(36, 30);
            npo[30].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // diamond2blue
            // 
            npo[31].BackColor = System.Drawing.Color.Transparent;
            npo[31].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[31].Location = new System.Drawing.Point(804, 653);
            npo[31].Name = "diamond2blue";
            npo[31].Size = new System.Drawing.Size(36, 29);
            npo[31].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[31].SendToBack();
            // 
            // diamond3red
            // 
            npo[32].BackColor = System.Drawing.Color.Transparent;
            npo[32].Image = global::TheSurvivor.Properties.Resources.DiamondRed;
            npo[32].Location = new System.Drawing.Point(983, 196);
            npo[32].Name = "diamond3red";
            npo[32].Size = new System.Drawing.Size(36, 29);
            npo[32].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // diamond4blue
            // 
            npo[33].BackColor = System.Drawing.Color.Transparent;
            npo[33].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[33].Location = new System.Drawing.Point(744, 445);
            npo[33].Name = "diamond4blue";
            npo[33].Size = new System.Drawing.Size(36, 29);
            npo[33].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // diamond5blue
            // 
            npo[34].BackColor = System.Drawing.Color.Transparent;
            npo[34].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[34].Location = new System.Drawing.Point(295, 421);
            npo[34].Name = "diamond5blue";
            npo[34].Size = new System.Drawing.Size(36, 29);
            npo[34].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // diamond6blue
            // 
            npo[35].BackColor = System.Drawing.Color.Transparent;
            npo[35].Image = global::TheSurvivor.Properties.Resources.DiamondBlue;
            npo[35].Location = new System.Drawing.Point(362, 108);
            npo[35].Name = "diamond6blue";
            npo[35].Size = new System.Drawing.Size(36, 29);
            npo[35].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // diamond7red
            // 
            npo[36].BackColor = System.Drawing.Color.Transparent;
            npo[36].Image = global::TheSurvivor.Properties.Resources.DiamondRed;
            npo[36].Location = new System.Drawing.Point(0, 2);
            npo[36].Name = "diamond7red";
            npo[36].Size = new System.Drawing.Size(36, 29);
            npo[36].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // movingFloor1
            // 
            npo[37].BackColor = System.Drawing.Color.Transparent;
            npo[37].Image = global::TheSurvivor.Properties.Resources.FloorBlueSmall;
            npo[37].Location = new System.Drawing.Point(394, 670);
            npo[37].Name = "movingFloor1";
            npo[37].Size = new System.Drawing.Size(70, 26);
            npo[37].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[37].StartX = npo[37].Left;
            npo[37].StartY = npo[37].Top;
            // 
            // movingFloor2
            // 
            npo[38].BackColor = System.Drawing.Color.Transparent;
            npo[38].Image = global::TheSurvivor.Properties.Resources.FloorDouble;
            npo[38].Location = new System.Drawing.Point(639, 328);
            npo[38].Name = "movingFloor2";
            npo[38].Size = new System.Drawing.Size(137, 27);
            npo[38].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[38].StartX = npo[38].Left;
            npo[38].StartY = npo[38].Top;
            // 
            // movingFloor3
            // 
            npo[39].BackColor = System.Drawing.Color.Transparent;
            npo[39].Image = global::TheSurvivor.Properties.Resources.FloorBlueSmall;
            npo[39].Location = new System.Drawing.Point(390, 219);
            npo[39].Name = "movingFloor3";
            npo[39].Size = new System.Drawing.Size(117, 33);
            npo[39].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[39].StartX = npo[39].Left;
            npo[39].StartY = npo[39].Top;
            // 
            // movingEnemy1
            // 
            npo[40].BackColor = System.Drawing.Color.Transparent;
            npo[40].Image = global::TheSurvivor.Properties.Resources.EnemyShortAll;
            npo[40].Location = new System.Drawing.Point(167, 523);
            npo[40].Name = "movingEnemy1";
            npo[40].Size = new System.Drawing.Size(54, 48);
            npo[40].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[40].StartX = npo[40].Left;
            npo[40].StartY = npo[40].Top;
            // 
            // movingEnemy2
            // 
            npo[41].BackColor = System.Drawing.Color.Transparent;
            npo[41].Image = global::TheSurvivor.Properties.Resources.EnemyShortAll;
            npo[41].Location = new System.Drawing.Point(287, 528);
            npo[41].Name = "movingEnemy2";
            npo[41].Size = new System.Drawing.Size(54, 48);
            npo[41].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[41].StartX = npo[41].Left;
            npo[41].StartY = npo[41].Top;
            // 
            // movingEnemy3
            // 
            npo[42].BackColor = System.Drawing.Color.Transparent;
            npo[42].Image = global::TheSurvivor.Properties.Resources.EnemyShortAll;
            npo[42].Location = new System.Drawing.Point(288, 303);
            npo[42].Name = "movingEnemy3";
            npo[42].Size = new System.Drawing.Size(54, 46);
            npo[42].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            npo[42].StartX = npo[42].Left;
            npo[42].StartY = npo[42].Top;
            // 
            // portal
            // 
            npo[43].BackColor = System.Drawing.Color.Transparent;
            npo[43].Image = global::TheSurvivor.Properties.Resources.Portal;
            npo[43].Location = new System.Drawing.Point(969, 56);
            npo[43].Name = "portal";
            npo[43].Size = new System.Drawing.Size(39, 74);
            npo[43].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // player
            // 
            player.BackColor = System.Drawing.Color.Transparent;
            player.Image = global::TheSurvivor.Properties.Resources.IdleRightSmall;
            player.Location = new System.Drawing.Point(9, 692);
            player.Name = "myPlayer";
            player.Size = new System.Drawing.Size(36, 50);
            player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // ladder1
            // 
            ladder1.Location = new System.Drawing.Point(980, 531);
            ladder1.Name = "ladder1";
            ladder1.Size = new System.Drawing.Size(44, 211);
            ladder1.Visible = false;
            // 
            // ladder2
            // 
            ladder2.Location = new System.Drawing.Point(830, 412);
            ladder2.Name = "ladder2";
            ladder2.Size = new System.Drawing.Size(54, 112);
            ladder2.Visible = false;
            // 
            // ladder3
            // 
            ladder3.Location = new System.Drawing.Point(45, 343);
            ladder3.Name = "ladder3";
            ladder3.Size = new System.Drawing.Size(40, 152);
            ladder3.Visible = false;
            // 
            // ladder4
            // 
            ladder4.Location = new System.Drawing.Point(530, 253);
            ladder4.Name = "ladder4";
            ladder4.Size = new System.Drawing.Size(44, 80);
            ladder4.Visible = false;

            //hiding
            for (int i = 0; i < 30; i++)
            {
                npo[i].Visible = false;
            }
            //adding
            for (int i = 0; i < 44; i++)
            {
                this.Controls.Add(npo[i]);
            }
            this.Controls.Add(player);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGame();
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
            timer1.Stop();
            PauseScreen pause = new PauseScreen(this);
            pause.Show();
        }

        private void UpdateGame()
        {
            //gravity : player falling constantly
            player.Top += (int)player.Gravity;
            if (player.Gravity < 6)
            {
                player.Gravity += 0.7f;
            }
            //testing ladder space
            if (player.PointInShape(ladder1) || player.PointInShape(ladder2) || player.PointInShape(ladder3) || player.PointInShape(ladder4))
            {
                CanClimb();
            }
            else
            {
                canClimb = false;
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
                if (up)
                {
                    MoveUp();
                }
                if (down)
                {
                    MoveDown();
                }
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
            for (int i = 37; i < 43; i++)
            {
                MoveNPO(npo[i]);
            }

            player.Collision(npo);
        }

        private void Jump()
        {
            if (player.Jump)
            {              
                player.Gravity = -11f;
                player.Jump = false;
            }
        }

        private void MoveUp()
        {
            if (canClimb)
                player.Top -= player.Velocity;
        }

        private void MoveDown()
        {
            if (canClimb)
                player.Top += player.Velocity;
        }

        private void MoveLeft()
        {
            player.Left -= player.Velocity;
        }

        private void MoveRight()
        {
            player.Left += player.Velocity;
        }

        private void NextLevel()
        {
            db.Score += db.Life * 200;
            timer1.Stop();
            Thread tr = new Thread(RunNextLevel);
            tr.Start();
            this.Close();
        }

        private void RunNextLevel()
        {
            Level3 lv3 = new Level3(db);
            Application.Run(lv3);
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

        private void CanClimb()
        {
            canClimb = true;
            player.Gravity = 0;
            player.Jump = true;
        }

        private void AddPointsBlue(int i)
        {
            db.Score += 100;
            Controls.Remove(npo[i]);
            npo[i] = null;
            ScorePoints.Text = db.Score.ToString();
        }

        private void AddPointsRed(int i)
        {
            db.Score += 150;
            Controls.Remove(npo[i]);
            npo[i] = null;
            ScorePoints.Text = db.Score.ToString();
        }

        private void AddPointsSpecial(int i)
        {
            db.Score += 1500;
            Controls.Remove(npo[i]);
            npo[i] = null;
            ScorePoints.Text = db.Score.ToString();
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
                timer1.Stop();
                Thread tr = new Thread(RunGameOverScreen);
                tr.Start();
                this.Close();
            }
        }

        private void RunGameOverScreen()
        {
            GameOverScreen gos = new GameOverScreen(this.db);
            Application.Run(gos);
        }

        private void Level2_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            if (Music.IsPlaying)
            {
                Music.Playlevel2();
            }
        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
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
                    case Keys.W:
                        {
                            if (canClimb)
                            {
                                playerIsMoving = true;
                                player.Climbing();
                                up = true;
                            }
                            break;
                        }
                    case Keys.S:
                        {
                            if (canClimb)
                            {
                                playerIsMoving = true;
                                player.Climbing();
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
                    case Keys.Up:
                        {
                            if (canClimb)
                            {
                                playerIsMoving = true;
                                player.Climbing();
                                up = true;
                            }
                            break;
                        }
                    case Keys.Down:
                        {
                            if (canClimb)
                            {
                                playerIsMoving = true;
                                player.Climbing();
                                down = true;
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

        private void Level2_KeyUp(object sender, KeyEventArgs e)
        {
            if (db.Wasd)
            {
                switch (e.KeyCode)
                {
                    case Keys.D:
                        {
                            player.IdleRight();
                            playerIsMoving = false;
                            right = false;
                            letMe = true;
                            break;
                        }
                    case Keys.A:
                        {
                            player.IdleLeft();
                            playerIsMoving = false;
                            left = false;
                            letMe = true;
                            break;
                        }
                    case Keys.W:
                        {
                            if (canClimb)
                            {
                                player.ClimbingIdle();
                            }
                            playerIsMoving = false;
                            up = false;
                            break;
                        }
                    case Keys.S:
                        {
                            if (canClimb)
                            {
                                player.ClimbingIdle();
                            }
                            playerIsMoving = false;
                            down = false;
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
                            player.IdleRight();
                            playerIsMoving = false;
                            right = false;
                            letMe = true;
                            break;
                        }
                    case Keys.Left:
                        {
                            player.IdleLeft();
                            playerIsMoving = false;
                            left = false;
                            letMe = true;
                            break;
                        }
                    case Keys.Up:
                        {
                            if (canClimb)
                            {
                                player.ClimbingIdle();
                            }
                            playerIsMoving = false;
                            up = false;
                            break;
                        }
                    case Keys.Down:
                        {
                            if (canClimb)
                            {
                                player.ClimbingIdle();
                            }
                            playerIsMoving = false;
                            down = false;
                            break;
                        }
                }
            }
        }
    }
}
