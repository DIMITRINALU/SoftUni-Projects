using System;
using System.Collections.Generic;
using System.Linq;

namespace P20.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            var bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;
            int cup = cups.Peek();

            while (cups.Any() && bottles.Any())
            {                
                int bottle = bottles.Pop();               

                if (bottle >= cup)
                {
                    bottle -= cup;
                    wastedWater += bottle;
                    cups.Dequeue();

                    if (cups.Any())
                    {
                        cup = cups.Peek();
                    }
                }
                else
                {
                    cup -= bottle;
                }
            }

            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");                
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");                
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}