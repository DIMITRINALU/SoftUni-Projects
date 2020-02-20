using System;
using System.Collections.Generic;

namespace P12.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbols = new SortedDictionary<char, int>();

            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];

                if (!symbols.ContainsKey(currentSymbol))
                {
                    symbols.Add(currentSymbol, 0);
                }

                symbols[currentSymbol]++;
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}