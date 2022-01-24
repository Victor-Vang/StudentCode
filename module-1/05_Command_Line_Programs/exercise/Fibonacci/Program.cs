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

            //0, 1, 1, 2

            int backOne = 1;
            int backTwo = 0;
            int current = 0;

            //int placeholder = 0;

            string fibStarter = "0, 1";

            //int[] fibonacciArray = new int[fibNumber];

            Console.Write(fibStarter);

            while (current <= fibNumber)
            {
                current = backOne + backTwo;


                //placeholder = backOne;

                backTwo = backOne;

                backOne = current;

                if (current <= fibNumber)
                {

                Console.Write(", " + current);

                }

            }

            


            //for (int i = 0; i < fibNumber; i++)
            //{
            //    int current = (backOne + backTwo);
            //    backOne = current;
            //    backTwo = backOne;
                
            //    if (current >= fibNumber)
            //    {
                    
            //    }
            //}


            //if (fibNumber <= 0)
            //{
            //    // Console.WriteLine(fibStarter);
            //}
            
        }
    }
}
