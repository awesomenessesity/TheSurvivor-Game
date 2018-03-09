using System;
using System.Windows.Forms;

namespace TheSurvivor
{
    [Flags]
    enum Direction { None = 0, Right = 1, Left = 2, Up = 4, Down = 8, Cycling = 16 };

    public delegate void WhatToDo();

    class NonPlayer : PictureBox
    {
        private bool enemy, sideEffect;
        private Direction directions = Direction.None;
        private int startX, startY, steps;
        public WhatToDo wtd;
        //construtor
        public NonPlayer(bool enemy, bool sideEffect, int steps, Direction directions)
        {
            this.enemy = enemy;
            this.sideEffect = sideEffect;
            this.steps = steps;
            this.directions = directions;
        }
        //copy contructor
        public NonPlayer(bool enemy, bool sideEffect, int steps, Direction directions, WhatToDo wtd) : this(enemy, sideEffect, steps, directions)
        {
            this.wtd = wtd;
        }

        //properties  
        public bool Enemy
        {
            get { return enemy; }
        }

        public bool SideEffect
        {
            get { return sideEffect; }
        }

        public Direction Direct
        {
            get { return directions; }
            set { directions = value; }
        }

        public int Steps
        {
            get { return steps; }
        }

        public int StartX
        {
            get { return startX; }
            set { startX = value; }
        }

        public int StartY
        {
            get { return startY; }
            set { startY = value; }
        }
    }
}
