using System;
using System.Collections.Generic;
using System.Linq;

namespace P09.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstSetLenght = input[0];
            int secondSetLenght = input[1];

            int totalLenght = firstSetLenght + secondSetLenght;

            for (int i = 0; i < totalLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < firstSetLenght)
                {
                    firstSet.Add(number);
                }
                else
                {
                    secondSet.Add(number);
                }           
            }

            foreach (var number in firstSet)
            {
                foreach (var num in secondSet)
                {
                    if (number == num)
                    {
                        Console.Write(number + " ");
                        break;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}