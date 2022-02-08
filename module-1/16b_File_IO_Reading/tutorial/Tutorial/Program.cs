using System;
using System.IO;

namespace FileIOReadingTutorial
{
    class Program
    {
        private const string BEGIN_MARKER = "*** START OF";
        private const string END_MARKER = "*** END OF";
        static void Main(string[] args)
        {
            /*
            * This book-reader program opens a file that was downloaded from https://www.gutenberg.org/, reads
            * through the copyright information at the top until it finds the start of the book content, and
            * then displays the content to the user. It also counts the total lines of book content between the
            * start and the end markers.
            */

            /*
            Step 1: Prompt the user for a filename
             */
            // Prompt the user for a file path - path should look like "data/jekyll-and-hyde.txt"
            Console.Write("Enter path to the book file: ");
            Console.Write("Enter path to the book file: ");
            //string filePath = Console.ReadLine();

            /*
            Step 2: Step Two: Open the book file and handle errors
            */

            int lineCount = 0;

            bool inBookText = false;

            try
            {
                using (StreamReader fileInput = new StreamReader(filePath))
                {
                    while (!fileInput.EndOfStream)
                    {
                        string lineOfText = fileInput.ReadLine();
                        if (lineOfText.StartsWith(BEGIN_MARKER))
                        {
                            inBookText = true;
                            continue;
                        }
                        if (lineOfText.StartsWith(END_MARKER))
                        {
                            break;
                        }
                        if (inBookText)
                        {
                            lineCount++;
                            Console.WriteLine(lineCount + ": " + lineOfText);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"Found {lineCount} lines of text in {filePath}");

        }
    }
}
