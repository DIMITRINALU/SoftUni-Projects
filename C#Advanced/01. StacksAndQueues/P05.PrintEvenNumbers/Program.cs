using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = queue.Dequeue();

                if (currentNumber % 2 == 0)
                {
                    queue.Enqueue(currentNumber);
                }                
            }

            Console.WriteLine(string.Join(", ", queue));
        }
    }
}