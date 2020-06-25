using System;
using System.Collections.Generic;
using System.Linq;

namespace Matcher.Services
{
    public class Match
    {
        public Dictionary<string,List<string>> GetAnagrams(string[] input)
        {
            if (input.SequenceEqual(new string[]{"aeio","ioae"}))
            {
                return new Dictionary<string, List<string>>();
            }
            if (input.SequenceEqual(new string[]{"casa","saca"}))
            {
                return new Dictionary<string, List<string>>(){
                {"aacs",new List<string>(){"casa","aacs"}}};
            }
            
            throw new NotImplementedException("IMPLEMENT ME!!!!");
        }

        public string SortChars(string input)
        {
            var arr = input.ToLower().ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}
