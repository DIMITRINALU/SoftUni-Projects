using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textLines = File.ReadAllLines("text.txt");
            string[] words = File.ReadAllLines("words.txt");

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsInfo.ContainsKey(word.ToLower()))
                {
                    wordsInfo.Add(word.ToLower(), 0);
                }
            }

            foreach (var line in textLines)
            {
                string[] lineWords = line.ToLower().Split(new char[] {' ', '-', ',', '.', '!', '?', '\'', ':', ';'});

                foreach (var currentWord in lineWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord]++;
                    }
                }
            }

            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText("actualResult.txt", $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("expectedResult.txt", $"{key} - {value}{Environment.NewLine}");
            }
        }
    }
}