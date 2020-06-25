using System;

class Read
{
    public string[] readfile(string file)
    {
        using(StreamReader reader = new StreamReader(file))
        {
            string[] wordslist;

            string line;
            for (int i = 0; line = reader.ReadLine() != null; i++)
            {
                wordslist[i] = line;

            }
            //while (line = reader.ReadLine() != null) 
    
        }return wordslist;
    }
}