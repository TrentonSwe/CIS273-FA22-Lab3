﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextualAnalysis
{
    public class TextualAnalysis
    {
        public static string stopWordFilePath = "../../../Data/test.txt";

        public TextualAnalysis()
        {
        }


        public static Dictionary<string, int> ComputeWordFrequencies(string s, bool ignoreStopWords = false)
        {
            var wordCounts = new Dictionary<string, int>();
            // s = "all the faith he had had had had no effect."
                string regexPattern = @"\p{P}";
                string regexResult = Regex.Replace(s, regexPattern, "");

                string[] words = regexResult.Split(" ")

                int numWords = words.Length;

                for (int i=0; i < numWords; i++)
                {
                    string curWord = words[!];
                    if (wordCounts.ContainsKey(curWord))
                    {
                        wordCounts[curWord] += 1;
                    }
                    else
                    {
                        wordCounts.Add(curWord, 1);
                    }
                }
            // remove punctuation
            
            // split the string into words (filtering out the empty strings)


            return wordCounts;
        }


        public static Dictionary<string, int> ComputeWordFrequenciesFromFile(string path, bool ignoreStopWords = false)
        {
            // read in the file
            string s = File.ReadAllText(path);
           
            Dictionary<string, int> result = ComputeWordFrequencies(s, ignoreStopWords);

            return result;
            // call the other method

            // return the result of the other method

            return null;
        }

        private static string[] GetStopWordsFromFile(string path)
        {
            var rawLines = System.IO.File.ReadAllLines(path);
            var lines = new List<string>();

            foreach (var line in rawLines)
            {
                // ignore blank lines
                if (line.Trim() != "")
                {
                    lines.Add(line.Trim().ToLower());
                }
            }

            return lines.ToArray();
        }

    }
}
