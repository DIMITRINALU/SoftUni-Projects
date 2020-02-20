using System;
using System.Collections.Generic;
using System.Linq;


namespace P01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var dict = new Dictionary<double, int>();

            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 0);
                }

                dict[num]++;    
            }

            foreach (var (key, value) in dict)
            {
                Console.WriteLine($"{key} - {value} times");
            }                
        }
    }
}