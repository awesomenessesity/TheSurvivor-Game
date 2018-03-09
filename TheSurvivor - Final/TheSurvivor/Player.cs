using System;
using System.Windows.Forms;
using System.Drawing;


namespace TheSurvivor
{
    class Player : PictureBox
    {
        private Point respawn;   
        private int velocity;
        private float gravity = 13.0f; 
        private bool jump = true;

        public Player(Point respawn, int velocity)
        {
            this.velocity = velocity;
            this.respawn = respawn;
        }

        public void Collision(params NonPlayer[] npo)
        {
            foreach (NonPlayer np in npo)
            {
                if (np != null)
                {
                    if (np.Enemy)
                    {
                        EnemyCollision(np);
                    }
                    else
                    {
                        WorldCollision(np);
                    }
                }
            }
        }

        public void EnemyCollision(NonPlayer npo)
        {
            if (PointInShape(npo))
            {
                npo.wtd();
                Location = respawn;
            }
        }

        public void WorldCollision(NonPlayer npo)
        {
            if (this.Bottom > npo.Top && this.Bottom < npo.Bottom) // comming from top
            {   //this is where stuff getting a bit tricky
                //comming FROM left TO right , 7 cause gravity max +1, concidering i fall full speed
                if (this.Bottom > (npo.Top + 7) && this.Right < (npo.Left + velocity + 3) && this.Right > npo.Left)//small green part on the left
                {
                    if (!npo.SideEffect)
                    {
                        this.Left = (npo.Left - this.Width - 1);//-1 testable
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
                //comming FROM right TO left , 7 cause gravity max +1, concidering i fall full speed
                else if (this.Bottom > (npo.Top + 7) && (this.Left > npo.Right - velocity - 3) && this.Left < npo.Right)//small yellow part right
                {
                    if (!npo.SideEffect)
                    {
                        this.Left = npo.Right + 1;//+1 testable
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
                //really comming from top!
                else if (this.Right > npo.Left && this.Left < npo.Right) // all the other red shit (top)
                {
                    if (!npo.SideEffect)
                    {
                        this.Top = (npo.Top - this.Height);//-1 testable
                        jump = true;
                        gravity = 0f;//gravity = platforms speed + direction
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
            }
            //comming from bottom!!
            else if (this.Top < npo.Bottom && this.Top > npo.Top)
            {   //comming FROM left TO right , 7 for now, depends on gravity and how u guys would like to poof ; extreme when jumping 0 distance
                if (this.Top < (npo.Bottom - 7) && this.Right > npo.Left && this.Right < (npo.Left + velocity + 1))//all green part left
                {
                    if (!npo.SideEffect)
                    {
                        this.Left = (npo.Left - this.Width);//-1 testable
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
                //comming FROM right TO left , 7 for now, depends on gravity and how u guys would like to poof ; extreme when jumping 0 distance
                else if (this.Top < (npo.Bottom - 7) && this.Left < npo.Right && this.Left > (npo.Right - velocity - 1))//all yellow part right
                {
                    if (!npo.SideEffect)
                    {
                        this.Left = npo.Right;//+1 testable
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
                //really coming from bottom!
                else if (this.Right > npo.Left && this.Left < npo.Right)//all the other red shit (bottom)
                {
                    if (!npo.SideEffect)
                    {
                        this.Top = npo.Bottom;//+1 testable
                        gravity = 0;//gravity = platforms speed + direction
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
            }
            // comming from either side **only happens if player higher than platform**
            else if (this.Top < npo.Top && this.Bottom > npo.Bottom)
            {   // comming FROM left TO right
                if (this.Right > npo.Left && this.Left < npo.Left)
                {
                    if (!npo.SideEffect)
                    {
                        this.Left = (npo.Left - this.Width);//-1 testable
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
                //comming FROM right TO left
                else if (this.Left < npo.Right && this.Right > npo.Right)
                {
                    if (!npo.SideEffect)
                    {
                        this.Left = npo.Right;//+1 testable
                        return;
                    }
                    else
                    {
                        npo.wtd();
                        return;
                    }
                }
            }
        }

        public bool PointInShape(NonPlayer npo)
        {
            if (this.Bottom > npo.Top && this.Top < npo.Bottom)
            {
                if (this.Right > npo.Left && this.Left < npo.Right)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public void MovingRight()
        {
            this.Image = global::TheSurvivor.Properties.Resources.RunRightSmall;
        }

        public void MovingLeft()
        {
            this.Image = global::TheSurvivor.Properties.Resources.RunLeftSmall;
        }

        public void IdleRight()
        {
            this.Image = global::TheSurvivor.Properties.Resources.IdleRightSmall;
        }

        public void IdleLeft()
        {
            this.Image = global::TheSurvivor.Properties.Resources.IdleLeftSmall;
        }

        public void Climbing()
        {
            this.Image = global::TheSurvivor.Properties.Resources.Climbing;
        }

        public void ClimbingIdle()
        {
            this.Image = global::TheSurvivor.Properties.Resources.ClimbingIdle;
        }

        public float Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        public int Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }

        public bool Jump
        {
            get { return jump; }
            set { jump = value; }
        }
    }
}
