namespace P22.FloatingEquality
{
    using System;

    class Program
    {
        static void Main()
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());

            double difference = Math.Abs(numberA - numberB);
            double epsilon = 0.000001;

            if (difference < epsilon)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}    