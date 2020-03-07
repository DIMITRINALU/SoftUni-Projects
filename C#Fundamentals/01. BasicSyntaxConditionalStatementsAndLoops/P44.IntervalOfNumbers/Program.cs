namespace P44.IntervalOfNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            var number1 = byte.Parse(Console.ReadLine());
            var number2 = byte.Parse(Console.ReadLine());

            var smallerNumber = Math.Min(number1, number2);
            var biggerNumber = Math.Max(number1, number2);

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}