using System;

namespace Lecture.Farming
{
    public class Chicken : FarmAnimal, ISingable, ISellable
    {
        public Chicken() : base("Chicken", "cluck")
        {
        }

        public decimal Price { get; } = 5;

        //public Chicken(string name, string sound) : base(name, sound)
        //{

        //}

        public void LayEgg()
        {
            Console.WriteLine("Chicken laid an egg!");
        }
    }
}
