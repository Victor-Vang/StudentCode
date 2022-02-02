using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class TriangleWall : Wall
    {

        //constructor

        public TriangleWall(string name, string color, int @base, int height) : base(name, color)
        {
            this.Base = @base;
            this.Height = height;
        }

        public int Base { get; }
        public int Height { get; }


        // methods

        public override int GetArea()
        {
            double triangleArea = (double)(Base * Height / 2);
            return (int)triangleArea;
        }

        public override string ToString()
        {
            return $"{Name} ({Base}x{Height}) triangle";
        }
    }
}
