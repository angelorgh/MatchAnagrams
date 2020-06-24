using NUnit.Framework;
using Matcher.Services;
using System.Collections.Generic;

namespace Matcher.UnitTests.Classes
{
    public class Matcher_MatchShould
    {
        private Match _matcherService;
        [SetUp]
        public void Setup()
        {
           _matcherService = new Match();
        }

        [Test]
        public void Match_Inputis1_2_3_ReturnsDictionary()
        {
            var result = _matcherService.GetAnagrams(new string[]{"abc","acb"});
            Assert.AreEqual(new Dictionary<string,List<string>>(){{"abc",
                new List<string>(){"abc","acb"}}}, result);
        }
    }
}