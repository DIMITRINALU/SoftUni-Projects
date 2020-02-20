using System;
using System.IO;
using System.Linq;

namespace P02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            
            int counter = 1;

            foreach (var line in lines)
            {
                int lettersCount = line.Count(char.IsLetter);
                int punctuationMarks = line.Count(char.IsPunctuation);

                File.AppendAllText("output.txt", $"Line {counter}: {line} ({lettersCount})({punctuationMarks}){Environment.NewLine}");

                counter++;                
            }
        }
    }
}