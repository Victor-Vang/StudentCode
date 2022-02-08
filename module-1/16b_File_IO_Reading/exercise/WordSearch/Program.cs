using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //string directory = Environment.CurrentDirectory;
            //string fileName = "alices_adventures_in_wonderland.txt";

            //1. Ask the user for the file path

            Console.Write("What is the fully qualified name of the file that should be searched? ");
            string filePath = Console.ReadLine();

            //2. Ask the user for the search string

            Console.WriteLine("What is the search word you are looking for? ");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y/N) ");
            string caseSensitiveAnswer = Console.ReadLine();

            //3. Open the file

            int lineCount = 0;

            try
            {
                //{
                using (StreamReader fileInput = new StreamReader(filePath))
                {
                    while (!fileInput.EndOfStream)
                    {
                        string lineOfText = fileInput.ReadLine();
                        lineCount++;
                        if (caseSensitiveAnswer == "Y" || caseSensitiveAnswer == "y") 
                        {
                            if (lineOfText.Contains(searchWord))
                            {
                                Console.WriteLine($"{lineCount}) {lineOfText}");
                            }
                        }
                        else
                        {
                            string lineOfTextLowered = lineOfText.ToLower();
                            if (lineOfTextLowered.Contains(searchWord.ToLower()))
                            {
                                Console.WriteLine($"{lineCount}) {lineOfText}");
                            }
                        }
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
//4. Loop through each line in the file
//5. If the line contains the search string, print it out along with its line number
