using System;
using System.Collections.Generic;

namespace P05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();

            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var name = Console.ReadLine();
                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}