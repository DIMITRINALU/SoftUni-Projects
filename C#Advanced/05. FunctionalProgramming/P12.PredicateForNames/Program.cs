using System;
using System.Linq;

namespace P12.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());


            Console.ReadLine()
                .Split()
                .Where(x => x.Length <= nameLength)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
