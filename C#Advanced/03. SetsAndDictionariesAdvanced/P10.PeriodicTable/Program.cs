using System;
using System.Collections.Generic;

namespace P10.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var chemicalElements = new SortedSet<string>();

            for (int i = 0; i < input; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    string currentElement = elements[j];
                    chemicalElements.Add(currentElement);
                }
            }

            foreach (var element in chemicalElements)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }
    }
}