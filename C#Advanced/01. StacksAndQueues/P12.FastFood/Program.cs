using System;
using System.Collections.Generic;
using System.Linq;

namespace P12.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodQuantity = int.Parse(Console.ReadLine());
            var ordersQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var orders = new Queue<int>(ordersQuantity);

            Console.WriteLine(orders.Max());            

            for (int i = 0; i < ordersQuantity.Length; i++)
            {
                int currentOrder = orders.Peek();

                if (foodQuantity >= currentOrder)
                {
                    orders.Dequeue();
                    foodQuantity -= currentOrder;
                }
            }

            if (orders.Any())
            {
                Console.WriteLine("Orders left: " + String.Join(" ", orders));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}