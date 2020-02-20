using System;
using System.Linq;

namespace P11.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();
            int n = int.Parse(Console.ReadLine());            

            numbers.Where(x => x % n != 0)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}