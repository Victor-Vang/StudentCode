using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length (numeric value): ");

            string userInput = Console.ReadLine();
            int length = int.Parse(userInput);

            Console.WriteLine("Is the measurement in (m)eter, or (f)eet? ");

            string userInputTwo = Console.ReadLine();

            int feetToMeters = (int)(length * 0.3048);
            int metersToFeet = (int)(length * 3.2808399);

            if (userInputTwo == "m")
            {
                Console.WriteLine(length + "m is " + metersToFeet + "f.");
            }
            else if (userInputTwo == "f")
            {
                Console.WriteLine(length + "f is " + feetToMeters + "m.");
            }

        }
    }
}
