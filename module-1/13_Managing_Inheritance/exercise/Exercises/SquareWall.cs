using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class SquareWall : RectangleWall
    {

        // constructor

        public SquareWall(string name, string color, int sideLength) : base(name, color, sideLength)
        {
            this.SideLength = sideLength;
        }

        public int SideLength { get; }


        // method

        public override string ToString()
        {
            return $"{Name} ({SideLength}x{SideLength}) square";
        }

    }
}
