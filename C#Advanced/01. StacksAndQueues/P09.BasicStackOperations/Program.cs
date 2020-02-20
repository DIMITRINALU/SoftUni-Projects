using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            var numbersToPush = operations[0];
            var numbersToPop = operations[1];
            var numbersToPeek = operations[2];            

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numbersToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}