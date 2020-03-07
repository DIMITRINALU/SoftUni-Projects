namespace P12.EvenNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }

                Console.WriteLine("Please write an even number.");

                number = int.Parse(Console.ReadLine());
            }
        }
    }
}