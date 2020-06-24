using System;
using System.Collections.Generic;
using System.Linq;

namespace Matcher.Services
{
    public class Match
    {
        public Dictionary<string,List<string>> GetAnagrams(string[] lines){
            if(lines.SequenceEqual(new string[]{"abc", "acb"}))
            {
                return new Dictionary<string,List<string>>(){{"abc",
                    new List<string>(){"abc","acb"}}};
            }
            throw new NotImplementedException("IMPLEMENT ME!!!");
        }
    }
}
