using NUnit.Framework;
using Matcher.Services;
using System.Collections.Generic;

namespace Matcher.UnitTests.Classes
{
    public class Matcher_MatchShould
    {
        private Match _matchServices;

        [SetUp]
        public void Setup()
        {
            _matchServices = new Match();
        }

        [Test]
        public void GetAnagrams_Returns_Dictionary()
        {
            var result = _matchServices.GetAnagrams(new string[]{"aeio","ioae"});
            Assert.IsInstanceOf(typeof(Dictionary<string, List<string>>) , result);
        }

        [Test]
        public void GetAnagrams_Returns_Dictionary_With_Correct_Values()
        {
            var result = _matchServices.GetAnagrams(new string[]{"casa","saca"});
            Assert.AreEqual(new Dictionary<string, List<string>>(){
                {"aacs",new List<string>(){"casa","saca"}}
                }, result);
            
        }
        
        [Test]
        public void GetAnagrams_With_cAsa_Saca_Pollo_id_di_caas_Returns_Dictionary_With_Correct_Values()
        {
            var result = _matchServices.GetAnagrams(new string[]{"cAsa","Saca","Pollo","id","di","caas"});
            Assert.AreEqual(new Dictionary<string, List<string>>(){
                { "aacs",new List<string>(){"cAsa","Saca","caas"} },
                { "lloop",new List<string>{"Pollo"}  },
                { "di",new List<string>(){"id","di"} }
                }, result);
            
        }

        [Test]

        public void SortChars_If_Input_Is_Casa_Returns_aacs()
        {
            var result = _matchServices.SortChars("casa");
            Assert.AreEqual("aacs", result);
        }

        [Test]

        public void SortChars_If_Input_Celular_Is_Capitalized_Returns_acellru()
        {
            var result = _matchServices.SortChars("Celular");
            Assert.AreEqual("acellru", result);
        }
    }
}