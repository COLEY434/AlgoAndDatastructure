using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure
{
    internal class DocumentProcessor : IDocumentProcessor
    {
        public Stats Analyze(string document)
        {
            var res = new Stats();
            string firstLongestWord = string.Empty;
            string firstShortestWord = string.Empty;

            var splittedWords = document.Split(' ', StringSplitOptions.TrimEntries);

            res.NumberOfAllWords = splittedWords.Length;

            foreach(var word in splittedWords)
            {
                if (IsDigitsOnly(word))
                {
                    res.NumberOfWordsThatContainOnlyDigits += 1;
                }

                if (word.StartsWith(word.ToLower()))
                {
                    res.NumberOfWordsStartingWithSmallLetter += 1;
                }

                if (word.StartsWith(word.ToUpper()))
                {
                    res.NumberOfWordsStartingWithCapitalLetter += 1;
                }

                if (word.Length > firstLongestWord.Length)
                {
                    firstLongestWord = word;
                }
                if (word.Length > firstShortestWord.Length)
                {
                    firstShortestWord = word;
                }
            }
            var sorted = splittedWords.OrderBy(n => n.Length);
            res.TheShortestWord = sorted.FirstOrDefault();
            res.TheLongestWord = firstLongestWord;

            return res;
        }


        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }


    public class Stats
    {
        // Total number of all words in the document
        public int NumberOfAllWords { get; set; }

        // Returns number of words that consist only from digits e.g. 13455, 98374
        public int NumberOfWordsThatContainOnlyDigits { get; set; }

        // Returns number of words that start with a lower letter e.g. a, d, z
        public int NumberOfWordsStartingWithSmallLetter { get; set; }

        // Returns number of words that start with a capital letter e.g. A, D, Z
        public int NumberOfWordsStartingWithCapitalLetter { get; set; }

        // Returns the first longest word in the document
        public string TheLongestWord { get; set; }

        // Returns the first shortest word in the document
        public string TheShortestWord { get; set; }
    }
}
