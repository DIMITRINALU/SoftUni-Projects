using System;
using System.Linq;

namespace P03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries)
                .Where(w => char.IsUpper(w[0]));

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}