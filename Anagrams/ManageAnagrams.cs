using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class ManageAnagrams
    {
        public int CountSets { get; set; }

        public Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> AnagramsDic(string word)
        {
            SortAndAddWords(word, myDictionary);
            

            return myDictionary;
        }

        public void SortAndAddWords(string word, Dictionary<string, List<string>> myDictionary)
        {
            string newWord = word.ToLower();
            newWord = new string(newWord.OrderBy(x => x).ToArray());

            if (myDictionary.ContainsKey(newWord))
            {
                if (!myDictionary[newWord].Contains(word))
                {
                    myDictionary[newWord].Add(word);
                }
            }
            else
            {
                myDictionary.Add(newWord, new List<string>());
                myDictionary[newWord].Add(word);
            }
        }

        public void PrintDic()
        {
            foreach (var set in myDictionary)
            {
                if (set.Value.Count > 1)
                {
                    Console.WriteLine(string.Join(" ", set.Value));
                    CountSets++;
                }
            }
        }

       
    }
}
