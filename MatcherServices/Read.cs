using System;
using System.IO;
using System.Collections.Generic;

namespace Matcher.Services
{
    public class Read
    {
        public string[] readfile(string file)
        {
            List<string> words = new List<string>();

            using(StreamReader reader = new StreamReader(file))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    words.Add(line);
                }
        
            }
            
            string[] wordslist = words.ToArray();

            return wordslist;
        }
    }
}