using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var operations = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            var numbersToEnqueue = operations[0];
            var numbersToDequeue = operations[1];
            var numbersToPeek = operations[2];

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numbersToPeek))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}