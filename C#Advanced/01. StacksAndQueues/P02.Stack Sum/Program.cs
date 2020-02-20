using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);            

            string commands = Console.ReadLine().ToLower();

            while (commands != "end")
            {
                var tokens = commands.Split();
                var command = tokens[0].ToLower();

                if (command.Equals("add"))
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else if (command.Equals("remove"))
                {
                    var countOfRemovedNums = int.Parse(tokens[1]);

                    if (countOfRemovedNums <= stack.Count)
                    {
                        for (int i = 0; i < countOfRemovedNums; i++)
                        {
                            stack.Pop();
                        }
                    }                    
                }

                commands = Console.ReadLine().ToLower();
            }

            var sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}