using System;
using System.Collections.Generic;

namespace P04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int indexOfOpeningBracket = stack.Pop();

                    string result = text.Substring(indexOfOpeningBracket, i - indexOfOpeningBracket + 1);

                    Console.WriteLine(result);
                }
            }
        }
    }
}