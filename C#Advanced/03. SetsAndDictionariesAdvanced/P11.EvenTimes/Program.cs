using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var numbers = new Dictionary<int, int>();

            for (int i = 0; i < input; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            foreach (var number in numbers.Where(n => n.Value % 2 == 0))
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}