using System;
using System.Collections.Generic;
using System.Linq;

namespace P15.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsQty = int.Parse(Console.ReadLine());

            Queue<int[]> pumps = new Queue<int[]>();
            FillQueue(pumpsQty, pumps);

            int counter = 0;

            while (true)
            {
                int fuel = 0;
                bool foundPoint = true;                

                foreach (var pump in pumps)
                {
                    fuel += pump[0];

                    if (fuel < pump[1])
                    {
                        foundPoint = false;
                        break;
                    }

                    fuel -= pump[1];
                }

                if (foundPoint)
                {
                    break;
                }

                counter++;
                pumps.Enqueue(pumps.Dequeue());
            }

            Console.WriteLine(counter);
        }

        private static void FillQueue(int pumpsQty, Queue<int[]> pumps)
        {
            for (int i = 0; i < pumpsQty; i++)
            {
                int[] currentPump = Console.ReadLine().Split().Select(int.Parse).ToArray();

                pumps.Enqueue(currentPump);
            }
        }
    }
}