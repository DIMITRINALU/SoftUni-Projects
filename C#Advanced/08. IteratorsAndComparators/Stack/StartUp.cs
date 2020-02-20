namespace Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string commands = Console.ReadLine();

            CustomStack<int> stack = new CustomStack<int>();

            while (commands != "END")
            {
                string[] splitedCommands = commands.Split(" ", 2);//splits input into two elements by the first space

                string command = splitedCommands[0];

                if (command == "Push")
                {
                    int[] elements = splitedCommands[1]
                        .Split(", ")
                        .Select(int.Parse)
                        .ToArray();

                    stack.Push(elements);
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }                    
                }

                commands = Console.ReadLine();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}