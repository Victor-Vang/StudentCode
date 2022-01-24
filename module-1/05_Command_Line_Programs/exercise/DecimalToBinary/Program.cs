using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");

            string userInput = Console.ReadLine();
            string[] numbersAsStrings = userInput.Split(" ");

                int[] convertedNumbers = new int[numbersAsStrings.Length];

            for (int i = 0; i < numbersAsStrings.Length; i++)
            {
                int numbersParsed = int.Parse(numbersAsStrings[i]);
                convertedNumbers[i] = numbersParsed;
                
            Console.WriteLine();        
            Console.WriteLine(convertedNumbers[i] + " in binary is " + Convert.ToString(convertedNumbers[i], 2));        
            }
        }
    }
}
