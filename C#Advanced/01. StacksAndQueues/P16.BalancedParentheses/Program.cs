using System;
using System.Collections.Generic;
using System.Linq;

namespace P16.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            var openingBrackets = new Stack<char>();

            if (parentheses.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var symbol in parentheses)
            {
                if (symbol == '(' || symbol == '[' || symbol == '{')
                {
                    openingBrackets.Push(symbol);
                }
                else if (symbol == ')' || symbol == ']' || symbol == '}' && openingBrackets.Any())
                {
                    if (openingBrackets.Peek() == '(' && symbol == ')' ||
                        openingBrackets.Peek() == '{' && symbol == '}' ||
                        openingBrackets.Peek() == '[' && symbol == ']')
                    {
                        openingBrackets.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}