using System;
using System.Collections.Generic;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the destination file? ");
            string destinationFile = Console.ReadLine();

            int[] numbers = new int[300];

            for (int i = 0; i < numbers.Length; i++)
            {
                int value = i + 1;
                numbers[i] = value;
            }

            List<string> numbersAsStrings = new List<string>();

            foreach (int item in numbers)
            {
                if (item % 15 == 0)
                {
                    string temporary = item.ToString();
                    temporary = "FizzBuzz";
                    numbersAsStrings.Add(temporary);
                }
                else if (item % 5 == 0)
                {
                    string temporary = item.ToString();
                    temporary = "Buzz";
                    numbersAsStrings.Add(temporary);
                }
                else if (item % 3 == 0)
                {
                    string temporary = item.ToString();
                    temporary = "Fizz";
                    numbersAsStrings.Add(temporary);
                }
                else
                {
                    string temporary = item.ToString();
                    numbersAsStrings.Add(temporary);
                }
            }

            try
            {
                using (StreamWriter fileOutput = new StreamWriter(destinationFile, false))
                {
                    foreach (string item in numbersAsStrings)
                    {
                        fileOutput.WriteLine(item);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
