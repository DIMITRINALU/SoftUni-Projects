namespace P12.TriplesOfLatinLetters
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());            

            for (char a = 'a'; a < 'a' + n; a++)
            {               
                for (char b = 'a'; b < 'a' + n; b++)
                {                   
                    for (char c = 'a'; c < 'a' + n; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }                    
                }
            }
        }
    }
}