using System;
using System.Linq;

namespace P17.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split()
                .ToArray();

            Func<string, int, bool> isLarger = (name, charactersSum)
                => name.Sum(x => x) >= charactersSum;

            Func<string[], Func<string, int, bool>, string> nameFilter =
                (inputNames, isLargerFilter) => inputNames.FirstOrDefault
                (x => isLargerFilter(x, number));

            string result = nameFilter(names, isLarger);

            Console.WriteLine(result);
        }
    }
}