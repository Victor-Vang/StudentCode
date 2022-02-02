using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class RectangleWall : Wall
    {

        // constructor

        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {

            this.Length = length;
            this.Height = height;

        }

        public RectangleWall(string name, string color, int sideLength) : base(name, color)
        {
            this.Length = sideLength;
            this.Height = Length;
        }

        public int Length { get; }
        public int Height { get; }

        // method

        public override int GetArea()
        {
            int rectangleArea = Length * Height;
            return rectangleArea;
        }

        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) rectangle";
        }

    }
}
