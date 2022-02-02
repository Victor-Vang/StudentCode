using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public abstract class Wall
    {
        // constructor

        public Wall(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }

        public string Name { get; }
        public string Color { get; }


        // method

        public abstract int GetArea();

    }
}
