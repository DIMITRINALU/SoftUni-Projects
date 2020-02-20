using System;
using System.Collections.Generic;
using System.Linq;

namespace P14.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int endRange = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split()
                .Distinct()
                .Select(int.Parse)
                .ToList();

            var divisibleNumbers = GetDivisibleNumbers(endRange, dividers);

            Console.WriteLine(String.Join(" ", divisibleNumbers));
        }

        private static List<int> GetDivisibleNumbers(int endRange, List<int> dividers)
        {
            var divisibleNumbers = new List<int>();

            for (int i = 1; i <= endRange; i++)
            {
                var isDivisible = true;

                foreach (var d in dividers)
                {
                    Predicate<int> isNotDivisor = x => i % x != 0;

                    if (isNotDivisor(d))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    divisibleNumbers.Add(i);
                }
            }

            return divisibleNumbers;
        }
    }
}