using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();

            foreach (var ch in input)
            {
                stack.Push(ch);
            }

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }

            Console.WriteLine();
        }
    }
}