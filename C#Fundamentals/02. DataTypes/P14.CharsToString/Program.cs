namespace P14.CharsToString
{
    using System;

    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
                                 
            Console.WriteLine($"{first}{second}{third}"); 
        }
    }
}