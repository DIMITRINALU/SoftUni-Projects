using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < input; i++)
            {
                var queries = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var operation = queries[0];

                if (operation == 1)
                {
                    var numberToPush = queries[1];
                    stack.Push(numberToPush);
                }
                else if (operation == 2)
                {
                    stack.Pop();
                }
                else if (operation == 3 && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
                else if (operation == 4 && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}