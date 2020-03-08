namespace P25.BalancedBrackets
{
    using System;

    class Program
    {
        static void Main()
        {
            byte lines = byte.Parse(Console.ReadLine());
            byte openedBracket = 0;
            byte closedBracket = 0;            

            while (lines > 0)
            {
                string currentString = Console.ReadLine();

                if (currentString == "(")
                {
                    openedBracket++;

                    if (openedBracket - closedBracket > 1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (currentString == ")")
                {
                    closedBracket++;

                    if (openedBracket - closedBracket != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

                lines--;
            }
            
            if (openedBracket == closedBracket)
            {
                Console.WriteLine("BALANCED"); 
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }            
        }
    }
}