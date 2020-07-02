using System;
using Matcher.Services;
using System.IO;
using System.Threading;

namespace matcherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File directory: ");
            var path =  Console.ReadLine();

            string[] wordslist;

            if(File.Exists(path))
            {
                Read read = new Read();
                wordslist = read.readfile(path);

                Match match = new Match();
                var result = match.GetAnagrams(wordslist);

                Display display = new Display();
                display.PrintOnScreen(result);
            }
            else{
                Console.WriteLine("Error: the file doesn't exist");
            }
        }
    }
}
