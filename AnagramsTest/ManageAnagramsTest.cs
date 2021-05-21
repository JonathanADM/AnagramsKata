using NUnit.Framework;
using Anagrams;
using System.Collections.Generic;

namespace AnagramsTest
{
    public class ManageAnagramsTest
    {
        public Dictionary<string, List<string>> myDictionary { get; set; }

        [SetUp]
        public void Setup()
        {
            myDictionary = new Dictionary<string, List<string>>()
            {
                ["moor"] = new List<string>() { "romo", "moro" },
                ["aaehlluy"] = new List<string>() { "aleluyah"},
            };
        }

        [Test]
        public void SortAndAddWords_Test()
        {
            Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>();
            ManageAnagrams manageAnagrams = new ManageAnagrams();
            manageAnagrams.SortAndAddWords("romo", expected);
            manageAnagrams.SortAndAddWords("moro", expected);
            manageAnagrams.SortAndAddWords("aleluyah", expected);

            Assert.AreEqual(expected, myDictionary);
        }
    }
}