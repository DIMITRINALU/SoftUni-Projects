namespace P10.MultiplicationTable
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int product;

            for (int i = 1; i <= 10; i++)
            {
                product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}