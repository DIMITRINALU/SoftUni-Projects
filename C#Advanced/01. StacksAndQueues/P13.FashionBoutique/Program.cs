using System;
using System.Collections.Generic;
using System.Linq;

namespace P13.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            var clothes = new Stack<int>(clothesBox);

            int newRack = rackCapacity;
            int racksCount = 1;

            while (clothes.Any())
            {
                int currentClothes = clothes.Peek();

                if (rackCapacity >= currentClothes)
                {
                    clothes.Pop();
                    rackCapacity -= currentClothes;
                }
                else
                {
                    rackCapacity = newRack;
                    racksCount++;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
