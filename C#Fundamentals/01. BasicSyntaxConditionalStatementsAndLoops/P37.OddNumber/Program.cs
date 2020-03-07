namespace P37.OddNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            short number = Math.Abs(short.Parse(Console.ReadLine()));
            bool isEven = number % 2 == 0;

            while (isEven)
            {
                Console.WriteLine("Please write an odd number.");
                number = Math.Abs(short.Parse(Console.ReadLine()));
                isEven = number % 2 == 0;
            }

            Console.WriteLine($"The number is: {number}");
        }
    }
}