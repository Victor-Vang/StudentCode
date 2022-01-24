using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter the temperature (number only): ");

            string userInput = Console.ReadLine();
            int temperature = int.Parse(userInput);

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit: ");

            string userInputTwo = Console.ReadLine();

            int farhenheitToCelsius = (int)((temperature - 32) / 1.8);
            int celsiusToFarhenheit = (int)(temperature * 1.8 + 32);

            if (userInputTwo == "C")
            {
                Console.WriteLine(temperature + "C is " + celsiusToFarhenheit + "F.");
            }
            else if (userInputTwo == "F")
            {
                Console.WriteLine(temperature + "F is " + farhenheitToCelsius + "C.");
            }
            else if ((userInputTwo != "C") || (userInputTwo != "F"))
            {
                Console.WriteLine("Input error: please try again and answer with the correct format (C or F)");
            }
        }
    }
}
