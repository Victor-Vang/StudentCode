using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the search word? ");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What is the replacement word? ");
            string replacementWord = Console.ReadLine();

            Console.WriteLine("What is the source file? ");
            string pathFile = Console.ReadLine();

            Console.WriteLine("What is the destination file? ");
            string destinationFile = Console.ReadLine();

            try
            {
                using (StreamReader inputFile = new StreamReader(pathFile))
                using (StreamWriter outputFile = new StreamWriter(destinationFile, false))
                {
                    while (!inputFile.EndOfStream)
                    {
                        string lineOfText = inputFile.ReadLine();
                        string replacementLine = lineOfText.Replace(searchWord, replacementWord);
                        outputFile.WriteLine(replacementLine);
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
