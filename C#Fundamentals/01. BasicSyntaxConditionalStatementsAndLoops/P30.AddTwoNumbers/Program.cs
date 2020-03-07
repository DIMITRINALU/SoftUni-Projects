namespace P30.AddTwoNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());

            var sum = number1 + number2;

            Console.WriteLine($"{number1} + {number2} = {sum}");
        }
    }
}