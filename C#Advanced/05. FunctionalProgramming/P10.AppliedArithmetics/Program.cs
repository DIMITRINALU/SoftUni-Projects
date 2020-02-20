using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string commands = Console.ReadLine();

            Func<int, int> add = x => x += 1;
            Func<int, int> multiply = x => x *= 2;
            Func<int, int> subtract = x => x -= 1;
            
            Action<List<int>> print = list =>
            {
                Console.WriteLine(string.Join(" ", list));
            };

            while (commands != "end")
            {                
                if(commands == "add")
                {
                    collection = collection.Select(add).ToList();
                }
                else if (commands == "multiply")
                {
                    collection = collection.Select(multiply).ToList();
                }
                else if (commands == "subtract")
                {
                    collection = collection.Select(subtract).ToList();
                }
                else if (commands == "print")
                {
                    print(collection);
                }

                commands = Console.ReadLine();
            }            
        }
    }
}