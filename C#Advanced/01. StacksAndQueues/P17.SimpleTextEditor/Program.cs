using System;
using System.Collections.Generic;
using System.Text;

namespace P17.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {            
            int operationsNumber = int.Parse(Console.ReadLine());

            StringBuilder someText = new StringBuilder();
            var text = new Stack<string>();

            for (int i = 0; i < operationsNumber; i++)
            {
                var commands = Console.ReadLine().Split();
                int command = int.Parse(commands[0]);

                if (command == 1)
                {
                    string appends = commands[1];
                    text.Push(someText.ToString());
                    someText.Append(appends);
                }
                else if (command == 2)
                {
                    int erases = int.Parse(commands[1]);
                    int index = someText.Length - erases;
                    text.Push(someText.ToString());
                    someText = someText.Remove(index, erases);
                }
                else if (command == 3)
                {  
                    int returns = int.Parse(commands[1]) - 1;
                    Console.WriteLine(someText[returns]);
                }
                else if (command == 4)
                {
                    someText = new StringBuilder();
                    someText.Append(text.Pop());
                }
            }
        }
    }
}
