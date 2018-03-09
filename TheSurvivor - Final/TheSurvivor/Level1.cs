using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace TheSurvivor
{
    public partial class Level1 : GameForm
    {
        Player player;
        bool playerIsMoving = false;
        bool right = false, up = false, down = false, left = false;
        int velocity = 2;
        Point respawn = new Point(108, 605);
        NonPlayer[] npo = new NonPlayer[52];
        NonPlayer ladder1, ladder2, ladder3;
        NonPlayer mush1;
        bool canClimb = false, letMe = true;

        public Level1(DataBase db)
        {
            this.db = db;
            InitializeComponent();
            InitializeMyComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            scoreP.Text = db.Score.ToString();
            pb1.Increment(db.Life);
            ChangeLifeColor();
            if (Music.IsPlaying)
            {
                Music.Playlevel1();
            }
        }

        private void InitializeMyComponent()
        {
            player = new Player(respawn, 4);

            ////*grounds*///// 
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

            //////////////////////////////////////////////////// 

            //*ladder*///
            ladder1 = new NonPlayer(false, true, 0, Direction.None);
            ladder2 = new NonPlayer(false, true, 0, Direction.None);
            ladder3 = new NonPlayer(false, true, 0, Direction.None);
            ////////////

            ////mushroom///////
            mush1 = new NonPlayer(false, true, 0, Direction.None, () => SubPointsM());

            npo[22] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(22));
            npo[23] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(23));
            npo[24] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(24));
            npo[25] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(25));
            npo[26] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(26));
            npo[27] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(27));
            npo[28] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(28));
            npo[29] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(29));
            npo[30] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsC(30));

            //**diamond**//
            npo[31] = new NonPlayer(false, true, 0, Direction.None, () => AddPointsD(31));

            //*falling*/// 
            npo[32] = new NonPlayer(false, false, 40, Direction.Down | Direction.Cycling);
            npo[33] = new NonPlayer(false, false, 35, Direction.Down | Direction.Cycling);
            npo[34] = new NonPlayer(false, false, 45, Direction.Up | Direction.Cycling);
            npo[35] = new NonPlayer(false, false, 50, Direction.Down | Direction.Cycling);
            npo[36] = new NonPlayer(false, false, 50, Direction.Up | Direction.Cycling);
            npo[37] = new NonPlayer(false, false, 40, Direction.Down | Direction.Cycling);

            //*spikes*// 
            npo[38] = new NonPlayer(true, false, 0, Direction.None, SubLife);//1
            npo[39] = new NonPlayer(true, false, 0, Direction.None, SubLife);//10-39 
            npo[40] = new NonPlayer(true, false, 0, Direction.None, SubLife);//11-40
            npo[41] = new NonPlayer(true, false, 0, Direction.None, SubLife);//12-41
            npo[42] = new NonPlayer(true, false, 0, Direction.None, SubLife);//13-42

            //*ninja-star*///
            npo[43] = new NonPlayer(true, false, 25, Direction.Up | Direction.Cycling, SubLife);//1-43
            npo[44] = new NonPlayer(true, false, 0, Direction.None, SubLife);//2-44
            npo[45] = new NonPlayer(true, false, 80, Direction.Up | Direction.Cycling, SubLife);//3-45

            //**movPlat**//
            npo[46] = new NonPlayer(false, false, 100, (Direction.Left | Direction.Cycling));//1-46
            npo[47] = new NonPlayer(false, false, 70, (Direction.Left | Direction.Cycling));//2-47 

            //**pipes**// 
            npo[48] = new NonPlayer(false, false, 0, Direction.None);//1-48
            npo[49] = new NonPlayer(false, false, 0, Direction.None);//2-49

            ////      //*moviPlat3**//
            npo[50] = new NonPlayer(false, false, 140, (Direction.Up | Direction.Cycling));//3-54 

            //**door**//
            npo[51] = new NonPlayer(false, true, 0, Direction.None, NextLevel);//52
            //
            //
            //properties// 
            //
            npo[33].Image = global::TheSurvivor.Properties.Resources.fallingNew;
            npo[33].Location = new System.Drawing.Point(616, 629);
            npo[33].Name = "death2";
            npo[33].Size = new System.Drawing.Size(88, 36);
            npo[33].StartX = npo[33].Left; npo[33].StartY = npo[33].Top;
            // 
            // ground2
            // 
            npo[1].Location = new System.Drawing.Point(939, 564);
            npo[1].Name = "ground2";
            npo[1].Size = new System.Drawing.Size(88, 36);
            npo[1].Visible = false;
            // 
            // ground3
            // 
            npo[2].Location = new System.Drawing.Point(753, 452);
            npo[2].Name = "ground3";
            npo[2].Size = new System.Drawing.Size(200, 53);
            npo[2].Visible = false;
            // 
            // spikes1
            // 
            npo[38].Location = new System.Drawing.Point(476, 734);
            npo[38].Name = "spikes1";
            npo[38].Size = new System.Drawing.Size(548, 38);
            npo[38].Visible = false;
            //********//
            /*ladder1*/
            //******// 
            ladder1.Location = new System.Drawing.Point(990, 460);
            ladder1.Name = "ladder1";
            ladder1.Size = new System.Drawing.Size(30, 101);
            ladder1.Visible = false;
            // 
            // movPlat1
            // 
            npo[46].Image = global::TheSurvivor.Properties.Resources.movPlat11;
            npo[46].Location = new System.Drawing.Point(450, 417);
            npo[46].Name = "movPlat1";
            npo[46].Size = new System.Drawing.Size(120, 20);
            npo[46].StartX = npo[46].Left;
            npo[46].StartY = npo[46].Top;
            // 
            // pipe1
            // 
            npo[48].Location = new System.Drawing.Point(154, 349);
            npo[48].Name = "pipe1";
            npo[48].Size = new System.Drawing.Size(59, 61);
            npo[48].Visible = false;
            // 
            // ground5-pipe2
            // 
            npo[4].Location = new System.Drawing.Point(0, 310);
            npo[4].Name = "ground5";
            npo[4].Size = new System.Drawing.Size(90, 47);
            npo[4].Visible = false;
            // 
            // pipe2
            // 
            npo[49].Location = new System.Drawing.Point(1, 270);
            npo[49].Name = "pipe2";
            npo[49].Size = new System.Drawing.Size(57, 30);
            npo[49].Visible = false;
            // 
            // death1
            // 
            npo[32].Image = global::TheSurvivor.Properties.Resources.miniFalling2;
            npo[32].Location = new System.Drawing.Point(503, 660);
            npo[32].Name = "death1";
            npo[32].Size = new System.Drawing.Size(60, 30);
            npo[32].StartX = npo[32].Left; npo[32].StartY = npo[32].Top;
            // 
            // death3
            // 
            npo[34].Image = global::TheSurvivor.Properties.Resources.fallingNew;
            npo[34].Location = new System.Drawing.Point(729, 655);
            npo[34].Name = "death3";
            npo[34].Size = new System.Drawing.Size(88, 36);
            npo[34].StartX = npo[34].Left;
            npo[34].StartY = npo[34].Top;
            // 
            // death4
            // 
            npo[35].Image = global::TheSurvivor.Properties.Resources.fallingNew;
            npo[35].Location = new System.Drawing.Point(829, 560);
            npo[35].StartX = npo[35].Left; npo[35].StartY = npo[35].Top;
            npo[35].Name = "death4";
            npo[35].Size = new System.Drawing.Size(88, 36);
            // 
            // ground4-after ninja1
            // 
            npo[3].Location = new System.Drawing.Point(616, 445);
            npo[3].Name = "ground4";
            npo[3].Size = new System.Drawing.Size(66, 31);
            npo[3].Visible = false;
            // 
            // spikes10-right of ninja1
            // 
            npo[39].Location = new System.Drawing.Point(386, 454);
            npo[39].Name = "spikes10";
            npo[39].Size = new System.Drawing.Size(60, 41);
            npo[39].Visible = false;
            // 
            // fire1
            // 
            npo[43].BackColor = System.Drawing.Color.Transparent;
            npo[43].Image = global::TheSurvivor.Properties.Resources.fire3;
            npo[43].Location = new System.Drawing.Point(700, 457);
            npo[43].Name = "ninjaStar1";
            npo[43].Size = new System.Drawing.Size(36, 35);
            npo[43].TabIndex = 38;
            npo[43].StartX = npo[43].Left; npo[43].StartY = npo[43].Top;
            npo[43].TabStop = false;
            // 
            // coin1
            //
            npo[22].BackColor = System.Drawing.Color.Transparent;
            npo[22].Image = global::TheSurvivor.Properties.Resources.Mycoin2;
            npo[22].SendToBack();
            npo[22].Location = new System.Drawing.Point(532, 620);
            npo[22].Name = "coin1";
            npo[22].Size = new System.Drawing.Size(25, 29);
            //
            // coin2
            // 
            npo[23].BackColor = System.Drawing.Color.Transparent;
            npo[23].Image = global::TheSurvivor.Properties.Resources.Mycoin;
            npo[23].SendToBack();
            npo[23].Location = new System.Drawing.Point(532, 585);
            npo[23].Name = "coin2";
            npo[23].Size = new System.Drawing.Size(25, 29);
            npo[23].TabIndex = 44;
            npo[23].TabStop = false;
            // 
            // coin3
            // 
            npo[24].BackColor = System.Drawing.Color.Transparent;
            npo[24].Image = global::TheSurvivor.Properties.Resources.Mycoin2;
            npo[24].SendToBack();
            npo[24].Location = new System.Drawing.Point(532, 550);
            npo[24].Name = "coin3";
            npo[24].Size = new System.Drawing.Size(25, 29);
            npo[24].TabIndex = 45;
            npo[24].TabStop = false;
            //
            // coin4
            // 
            npo[25].BackColor = System.Drawing.Color.Transparent;
            npo[25].Image = global::TheSurvivor.Properties.Resources.Mycoin2;
            npo[25].SendToBack();
            npo[25].Location = new System.Drawing.Point(949, 532);
            npo[25].Name = "coin4";
            npo[25].Size = new System.Drawing.Size(25, 29);
            npo[25].TabIndex = 46;
            npo[25].TabStop = false;
            // 
            // coin5
            // 
            npo[26].BackColor = System.Drawing.Color.Transparent;
            npo[26].Image = global::TheSurvivor.Properties.Resources.Mycoin;
            npo[26].SendToBack();
            npo[26].Location = new System.Drawing.Point(254, 370);
            npo[26].Name = "coin5";
            npo[26].Size = new System.Drawing.Size(25, 29);
            npo[26].TabIndex = 47;
            npo[26].TabStop = false;
            // 
            // fire2
            // 
            npo[44].BackColor = System.Drawing.Color.Transparent;
            npo[44].Image = global::TheSurvivor.Properties.Resources.fire3;
            npo[44].Location = new System.Drawing.Point(334, 465);
            npo[44].Name = "ninjaStar2";
            npo[44].Size = new System.Drawing.Size(36, 35);
            npo[44].TabIndex = 48;
            npo[44].TabStop = false;
            // 
            // movPlat2
            // 
            npo[47].Image = global::TheSurvivor.Properties.Resources.movPlat21;
            npo[47].Location = new System.Drawing.Point(100, 220);
            npo[47].Name = "movPlat2";
            npo[47].Size = new System.Drawing.Size(100, 20);
            npo[47].TabIndex = 49;
            npo[47].StartX = npo[47].Left; npo[47].StartY = npo[47].Top;
            npo[47].TabStop = false;
            // 
            // death5
            // 
            npo[36].Image = global::TheSurvivor.Properties.Resources.fallingNew;
            npo[36].Location = new System.Drawing.Point(272, 230);
            npo[36].Name = "death5";
            npo[36].Size = new System.Drawing.Size(88, 36);
            npo[36].TabIndex = 50;
            npo[36].StartX = npo[36].Left; npo[36].StartY = npo[36].Top;
            npo[36].TabStop = false;
            // 
            // death6
            // 
            npo[37].Image = global::TheSurvivor.Properties.Resources.fallingNew;
            npo[37].Location = new System.Drawing.Point(386, 244);
            npo[37].Name = "death6";
            npo[37].Size = new System.Drawing.Size(88, 36);
            npo[37].TabIndex = 51;
            npo[37].StartX = npo[37].Left; npo[37].StartY = npo[37].Top;
            npo[37].TabStop = false;
            // 
            // spikes11-between pipes
            // 
            npo[40].Location = new System.Drawing.Point(88, 328);
            npo[40].Name = "spikes11";
            npo[40].Size = new System.Drawing.Size(59, 38);
            npo[40].TabIndex = 52;
            npo[40].TabStop = false;
            npo[40].Visible = false;
            // 
            // ground6-up ladder2
            // 
            npo[5].Location = new System.Drawing.Point(496, 235);
            npo[5].Name = "ground6";
            npo[5].Size = new System.Drawing.Size(84, 31);
            npo[5].Visible = false;
            // 
            // ladder2
            // 
            ladder2.Location = new System.Drawing.Point(588, 243);
            ladder2.Name = "ladder2";
            ladder2.Size = new System.Drawing.Size(30, 76);
            ladder2.Visible = false;
            // 
            // ground7-laddder2 
            // 
            npo[6].Location = new System.Drawing.Point(580, 320);
            npo[6].Name = "ground7";
            npo[6].Size = new System.Drawing.Size(162, 29);
            npo[6].Visible = false;
            // 
            // coin6
            // 
            npo[27].BackColor = System.Drawing.Color.Transparent;
            npo[27].Image = global::TheSurvivor.Properties.Resources.Mycoin2;
            npo[27].SendToBack();
            npo[27].Name = "coin6";
            npo[27].Size = new System.Drawing.Size(25, 29);
            npo[27].TabIndex = 56;
            npo[27].Location = new System.Drawing.Point(412, 335);
            npo[27].TabStop = false;
            // 
            // coin7
            // 
            npo[28].BackColor = System.Drawing.Color.Transparent;
            npo[28].Image = global::TheSurvivor.Properties.Resources.Mycoin;
            npo[28].SendToBack();
            npo[28].Location = new System.Drawing.Point(412, 192);
            npo[28].Name = "coin7";
            npo[28].Size = new System.Drawing.Size(25, 29);
            npo[28].TabIndex = 57;
            npo[28].TabStop = false;
            // 
            // movPlat3- left Up plat
            //
            npo[50].Image = global::TheSurvivor.Properties.Resources.movPlat31;
            npo[50].Location = new System.Drawing.Point(743, 390);
            npo[50].Name = "movPlat3";
            npo[50].Size = new System.Drawing.Size(40, 20);
            npo[50].TabIndex = 58;
            npo[50].TabStop = false;
            npo[50].StartX = npo[50].Left; npo[50].StartY = npo[50].Top;
            // 
            // ground8-greenFloor before tree
            // 
            npo[7].Location = new System.Drawing.Point(813, 278);
            npo[7].Name = "ground8";
            npo[7].Size = new System.Drawing.Size(53, 30);
            npo[7].TabIndex = 59;
            npo[7].TabStop = false;
            npo[7].Visible = false;
            // 
            // ground9-tree
            // 
            npo[8].BackColor = System.Drawing.Color.Transparent;
            npo[8].Location = new System.Drawing.Point(880, 235);
            npo[8].Name = "ground9";
            npo[8].Size = new System.Drawing.Size(147, 30);
            npo[8].TabIndex = 60;
            npo[8].TabStop = false;
            npo[8].Visible = false;
            // 
            // coin8
            // 
            npo[29].BackColor = System.Drawing.Color.Transparent;
            npo[29].Image = global::TheSurvivor.Properties.Resources.Mycoin2;
            npo[29].SendToBack();
            npo[29].Location = new System.Drawing.Point(752, 208);
            npo[29].Name = "coin8";
            npo[29].Size = new System.Drawing.Size(25, 29);
            npo[29].TabIndex = 62;
            npo[29].TabStop = false;
            // 
            // ground11-down ladder3
            // 
            npo[10].Location = new System.Drawing.Point(826, 168);
            npo[10].Name = "ground11";
            npo[10].Size = new System.Drawing.Size(63, 20);
            npo[10].TabIndex = 64;
            npo[10].TabStop = false;
            npo[10].Visible = false;
            // 
            // ground12-down ground11
            // 
            npo[11].Location = new System.Drawing.Point(889, 178);
            npo[11].Name = "ground12";
            npo[11].Size = new System.Drawing.Size(20, 10);
            npo[11].Visible = false;
            // 
            // ground13-left of ninja3
            // 
            npo[12].Location = new System.Drawing.Point(437, 122);
            npo[12].Name = "ground13";
            npo[12].Size = new System.Drawing.Size(65, 14);
            npo[12].Visible = false;
            // 
            // ground14
            // 
            npo[13].Location = new System.Drawing.Point(346, 106);
            npo[13].Name = "ground14";
            npo[13].Size = new System.Drawing.Size(67, 11);
            npo[13].Visible = false;
            // 
            // ground15
            // 
            npo[14].Location = new System.Drawing.Point(246, 84);
            npo[14].Name = "ground15";
            npo[14].Size = new System.Drawing.Size(67, 11);
            npo[14].Visible = false;
            // 
            // ground16- before diamond
            // 
            npo[15].Location = new System.Drawing.Point(149, 68);
            npo[15].Name = "ground16";
            npo[15].Size = new System.Drawing.Size(69, 11);
            npo[15].Visible = false;
            // 
            // coin9
            // 
            npo[30].BackColor = System.Drawing.Color.Transparent;
            npo[30].Image = global::TheSurvivor.Properties.Resources.Mycoin;
            npo[30].SendToBack();
            npo[30].Location = new System.Drawing.Point(364, 77);
            npo[30].Name = "coin9";
            npo[30].Size = new System.Drawing.Size(25, 29);
            npo[30].TabIndex = 70;
            npo[30].TabStop = false;
            // 
            //apple-diamond
            // 
            npo[31].BackColor = System.Drawing.Color.Transparent;
            npo[31].Image = global::TheSurvivor.Properties.Resources.apple;
            npo[31].SendToBack();
            npo[31].Location = new System.Drawing.Point(87, 93);
            npo[31].Name = "diamond";
            npo[31].Size = new System.Drawing.Size(25, 29);
            npo[31].TabIndex = 71;
            npo[31].TabStop = false;
            // 
            // ground17-diamond
            // 
            npo[16].Location = new System.Drawing.Point(25, 142);
            npo[16].Name = "ground17";
            npo[16].Size = new System.Drawing.Size(69, 11);
            npo[16].TabIndex = 72;
            npo[16].TabStop = false;
            npo[16].Visible = false;
            // 
            // spikes12 right upper
            // 
            npo[41].Location = new System.Drawing.Point(728, 125);
            npo[41].Name = "spikes12";
            npo[41].Size = new System.Drawing.Size(48, 25);
            npo[41].TabIndex = 74;
            npo[41].TabStop = false;
            npo[41].Visible = false;
            // 
            // fire3
            // 
            npo[45].BackColor = System.Drawing.Color.Transparent;
            npo[45].Image = global::TheSurvivor.Properties.Resources.fire3;
            npo[45].Location = new System.Drawing.Point(503, 117);
            npo[45].Name = "ninjaStar3";
            npo[45].Size = new System.Drawing.Size(36, 35);
            npo[45].StartX = npo[45].Left; npo[45].StartY = npo[45].Bottom;
            npo[45].TabIndex = 75;
            npo[45].TabStop = false;
            // 
            // spikes13-left upper
            // 
            npo[42].Location = new System.Drawing.Point(595, 124);
            npo[42].Name = "spikes13";
            npo[42].Size = new System.Drawing.Size(48, 25);
            npo[42].Visible = false;
            // 
            // ground10- two spikes up 
            // 
            npo[9].Location = new System.Drawing.Point(538, 141);
            npo[9].Name = "ground10";
            npo[9].Size = new System.Drawing.Size(292, 38);
            npo[9].Visible = false;
            // 
            // ladder3
            // 
            ladder3.Location = new System.Drawing.Point(852, 103);
            ladder3.Name = "ladder3";
            ladder3.Size = new System.Drawing.Size(31, 64);
            ladder3.Visible = false;
            // 
            // ground18-door
            // 
            npo[17].Location = new System.Drawing.Point(888, 100);
            npo[17].Name = "ground18";
            npo[17].Size = new System.Drawing.Size(124, 17);
            npo[17].Visible = false;
            // 
            // doorOut
            // 
            npo[51].Location = new System.Drawing.Point(945, 35);
            npo[51].Name = "doorOut";
            npo[51].Size = new System.Drawing.Size(30, 60);
            npo[51].Visible = false;

            // 
            // ground19-pipe1
            // 
            npo[18].Location = new System.Drawing.Point(154, 410);
            npo[18].Name = "ground19";
            npo[18].Size = new System.Drawing.Size(159, 47);
            npo[18].Visible = false;
            // 
            // ground1
            // 
            npo[0].Name = "ground1";
            npo[0].Size = new System.Drawing.Size(477, 130);
            npo[0].Location = new System.Drawing.Point(0, 650);
            npo[0].Visible = false;
            //
            //mush1
            //
            mush1.BackColor = System.Drawing.Color.Transparent;
            mush1.Image = global::TheSurvivor.Properties.Resources.mushroom1;
            mush1.Location = new System.Drawing.Point(1065, 140);
            mush1.Name = "mush1";
            mush1.Size = new System.Drawing.Size(25, 29);
            mush1.Visible = false;
            //
            //lables + proccessBar
            //
            hpl.BackColor = System.Drawing.Color.Transparent;
            Scorelab.BackColor = System.Drawing.Color.Transparent;
            scoreP.BackColor = System.Drawing.Color.Transparent;
            // 
            // playerBox
            // 
            player.Image = global::TheSurvivor.Properties.Resources.IdleNonGif;
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.BackColor = Color.Transparent;
            player.Location = new System.Drawing.Point(108, 605);
            player.Name = "playerBox";
            player.Size = new System.Drawing.Size(35, 45);
            player.TabIndex = 12;
            player.TabStop = false;
            player.BringToFront();
            for (int i = 0; i < 51; i++)
            {
                this.Controls.Add(npo[i]);
            }
            this.Controls.Add(player);
            this.Controls.Add(mush1);
            this.Controls.Add(hpl);
            this.Controls.Add(pb1);
            this.Controls.Add(Scorelab);
            this.Controls.Add(scoreP);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGame();
        }

        private void UpdateGame()
        {
            player.Top += (int)player.Gravity;
            if (player.Gravity < 6)
            {
                player.Gravity += 0.4f;
            }

            if (player.PointInShape(ladder1) || player.PointInShape(ladder2) || player.PointInShape(ladder3))
            {
                CanClimb();
            }
            else
            {
                canClimb = false;
            }

            if (playerIsMoving)
            {
                if (up) { MoveUp(); }
                if (down) { MoveDown(); }
                if (right) { MoveRight(); }
                if (left) { MoveLeft(); }
            }

            if (player.Right > panel1.Right)
            {
                player.Left = panel1.Right - player.Width - 2;
            }
            if (player.Left < panel1.Left)
            {
                player.Left = panel1.Left;
            }
            //moving nonPlayer falling/movPlat
            MoveNPO(npo[46]);
            MoveNPO(npo[47]);
            MoveNPO(npo[50]);
            MoveNPO(npo[32]);//falling
            MoveNPO(npo[33]);//falling
            MoveNPO(npo[34]);//falling
            MoveNPO(npo[35]);//falling
            MoveNPO(npo[36]);//falling
            MoveNPO(npo[37]);//falling
            MoveNPO(npo[43]);//falling
            MoveNPO(npo[45]);//falling

            player.Collision(npo);
            player.Collision(mush1);
        }

        private void Jump()
        {
            if (player.Jump)
            {
                player.Gravity -= 8;
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
            Level2 lv2 = new Level2(db);
            Application.Run(lv2);
        }

        private void MoveNPO(NonPlayer npo)
        {
            if (npo.Direct == (Direction.Left | Direction.Cycling))
            {
                if (npo.Left > npo.StartX - npo.Steps)
                {
                    npo.Left -= velocity;
                }
                else
                {
                    npo.Direct = (Direction.Right | Direction.Cycling);
                    npo.StartX = npo.Left;
                }
            }
            else if (npo.Direct == (Direction.Right | Direction.Cycling))
            {
                if (npo.Left < npo.StartX + npo.Steps)
                {
                    npo.Left += velocity;
                }
                else
                {
                    npo.Direct = (Direction.Cycling | Direction.Left);
                    npo.StartX = npo.Left;
                }
            }
            else if (npo.Direct == (Direction.Up | Direction.Cycling))
            {
                if (npo.Top > npo.StartY - npo.Steps)
                {
                    npo.Top -= velocity;
                }
                else
                {
                    npo.Direct = (Direction.Down | Direction.Cycling);
                    npo.StartY = npo.Top;
                }
            }
            else if (npo.Direct == (Direction.Down | Direction.Cycling))
            {
                if (npo.Top < npo.StartY + npo.Steps)
                {
                    npo.Top += velocity;
                }
                else
                {
                    npo.Direct = (Direction.Up | Direction.Cycling);
                    npo.StartY = npo.Top;
                }
            }
        }

        private void CanClimb()
        {
            canClimb = true;
            player.Gravity = 0;
            player.Jump = true;
        }

        private void SubPointsM()
        {
            db.Score -= 200;
            scoreP.Text = db.Score.ToString();
            mush1.Location = new Point(2000, 10000);
            mush1 = null;
            this.Controls.Remove(mush1);
        }

        private void AddPointsD(int i)
        {
            Controls.Remove(npo[i]);
            npo[45].Location = new Point(209, 195);
            mush1.Visible = true;
            mush1.Location = new Point(168, 33);
            db.Score += 200;
            scoreP.Text = db.Score.ToString();
            npo[i] = null;
        }

        private void AddPointsC(int i)
        {
            Controls.Remove(npo[i]);
            db.Score += 100;
            scoreP.Text = db.Score.ToString();
            npo[i] = null;
        }

        private void ChangeLifeColor()
        {
            if (db.Life < 7)
            {
                pb1.ForeColor = Color.Red;
            }
            else if (db.Life < 11)
            {
                pb1.ForeColor = Color.Yellow;
            }
            else
            {
                pb1.ForeColor = Color.Green;
            }
        }

        private void SubLife()
        {
            db.Life--;
            pb1.Increment(-1);
            ChangeLifeColor();
            if (db.Life == 0)
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

        private void Level1_Activated(object sender, EventArgs e)
        {
            timer1.Start();
            if (Music.IsPlaying)
            {
                Music.Playlevel1();
            }
        }

        private void Level1_KeyUp(object sender, KeyEventArgs e)
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
            else {
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

        private void Level1_KeyDown(object sender, KeyEventArgs e)
        {
            if(db.Wasd)
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
    }
}

