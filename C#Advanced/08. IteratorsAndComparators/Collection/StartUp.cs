namespace ListyIterator
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            var elements = command
                .Split()
                .Skip(1)
                .ToList();

            var listyIterator = new ListyIterator<string>(elements);

            while (command != "END")
            {
                if (command == "Move")
                {
                    bool result = listyIterator.Move();
                    Console.WriteLine(result);
                }
                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                else if (command == "HasNext")
                {
                    bool result = listyIterator.HasNext();
                    Console.WriteLine(result);
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", listyIterator));
                }

                command = Console.ReadLine();
            }
        }
    }
}