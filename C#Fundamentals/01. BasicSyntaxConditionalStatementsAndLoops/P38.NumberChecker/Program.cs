namespace P38.NumberChecker
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}