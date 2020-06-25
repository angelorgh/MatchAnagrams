using System;
using System.Collections.Generic;
using System.Linq;

namespace Matcher.Services
{
    public class Match
    {
        public Dictionary<string,List<string>> GetAnagrams(string[] input)
        {
            var result = new Dictionary<string, List<string>>();
            foreach (string word in input)
            {
                string sortedWord = SortChars(word);
                if(result.TryGetValue(sortedWord, out List<string> wordList)){
                    wordList.Add(word);
                } else {
                    result.Add(sortedWord,new List<string>{word});
                }
            }
            return result;
        }

        public string SortChars(string input)
        {
            var arr = input.ToLower().ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}
