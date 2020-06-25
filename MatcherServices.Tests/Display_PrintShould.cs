using System.Collections.Generic;
using Matcher.Services;
using NUnit.Framework;

namespace Matcher.UnitTests.Classes {
    public class Display_PrintShould {
        private Display _displayService;

        [SetUp]
        public void Setup () {
            _displayService = new Display ();
        }

        [Test]
        public void Get_string_Dictionary () {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>> ();
            dictionary.Add ("amor", new List<string> { "amor", "roma", "ramo", "mora", "arom", "maro" });
            dictionary.Add ("sapo", new List<string> { "sopa", "posa", "paso", "sapo", "asop", "soap" });
            dictionary.Add ("ana", new List<string> { "ana", "aan", "naa" });
            dictionary.Add ("deuda", new List<string> { "dudae", "dadue", "aeudd", "daeud", "deuda" });

            string result = _displayService.Print (dictionary);
            Assert.AreEqual (result, "amor roma ramo mora arom maro \n sopa posa paso sapo asop soap \n ana aan naa \n dudae dadue aeudd daeud deuda \n ");
        }

        [Test]
        public void Get_string_Invalid_Dictionary () {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>> ();
            string result = _displayService.Print (dictionary);
            Assert.AreEqual (result, "Invalid dictionary");
        }

        [Test]

        public void Get_string_Valid_Dictionary () {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>> ();
            dictionary.Add ("amor", new List<string> { "amor", "roma", "ramo", "mora", "arom", "maro" });
            dictionary.Add ("sapo", new List<string> { "sopa", "posa", "paso", "sapo", "asop", "soap" });
            dictionary.Add ("ana", new List<string> { "ana", "aan", "naa" });
            dictionary.Add ("deuda", new List<string> { "dudae", "dadue", "aeudd", "daeud", "deuda" });
            bool result = _displayService.Validate (dictionary);
            Assert.AreEqual (result, true);

        }

        [Test]
        public void Get_string_invalid_Dictionary () {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>> ();
            bool result = _displayService.Validate (dictionary);
            Assert.AreEqual (result, false);

        }

    }
}