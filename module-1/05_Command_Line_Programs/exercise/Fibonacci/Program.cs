using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();
            int fibNumber = int.Parse(userInput);

            int backOne = 1;
            int backTwo = 0;

            // string fibStarter = "0, 1";

            int[] fibonacci = new int []

            for (int i = 0; i < fibNumber; i++)
            {
                int current = (backOne + backTwo);
                backOne = current;
                backTwo = backOne;
                
                if (current >= fibNumber)
                {
                    
                }
            }


            if (fibNumber <= 0)
            {
                Console.WriteLine(fibStarter);
            }
            
        }
    }
}
