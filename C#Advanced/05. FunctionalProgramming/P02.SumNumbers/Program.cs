using System;
using System.Linq;

namespace P02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> myFunc = int.Parse;

            var numbers = Console.ReadLine().Split(", ").Select(myFunc).ToList();

            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());
        } 
    }
}  