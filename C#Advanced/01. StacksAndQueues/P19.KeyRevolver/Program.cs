using System;
using System.Collections.Generic;
using System.Linq;

namespace P19.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] bulletsValue = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locksValue = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsValue);
            Stack<int> locks = new Stack<int>(locksValue);

            int count = 0;
            int bulletsCount = bullets.Count;

            while (bullets.Any() && locks.Any())
            {
                int bullet = bullets.Pop();
                int @lock = locks.Pop();// lock is a keyword

                if (bullet > @lock)
                {
                    Console.WriteLine($"Ping!");
                    locks.Push(@lock);
                }
                else
                {
                    Console.WriteLine($"Bang!");
                }

                count++;

                if (count == gunBarrelSize && bullets.Any())
                {
                    Console.WriteLine($"Reloading!");
                    count = 0;
                }
            }
            
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int leftMoney = intelligenceValue - (bulletsCount - bullets.Count) * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${leftMoney}");
            }
        }
    }
}