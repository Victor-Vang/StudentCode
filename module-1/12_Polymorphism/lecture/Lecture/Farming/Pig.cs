using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Pig : FarmAnimal, ISellable
    {
        public Pig() : base("Pig", "oink")
        {

        }

        public decimal Price { get; } = 50;

    }
}
