using System;
using System.Linq;

namespace P04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine()
                        .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .Select(n => n * 1.2)
                        .ToArray();

            foreach (var price in prices)

                Console.WriteLine($"{price:f2}");
        }
    }
}