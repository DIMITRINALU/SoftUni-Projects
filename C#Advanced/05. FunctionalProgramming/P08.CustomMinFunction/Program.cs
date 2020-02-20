using System;
using System.Linq;

namespace P08.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> minValue = (array) =>
            {
                return array.Min();
            };

            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(minValue(array));
        }
    }
}