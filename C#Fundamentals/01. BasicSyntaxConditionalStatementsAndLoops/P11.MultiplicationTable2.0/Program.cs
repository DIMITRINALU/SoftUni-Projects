namespace P11.MultiplicationTable2._0
{
    using System;
    
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product;

            if (multiplier > 10)
            {
                product = number * multiplier;
                Console.WriteLine($"{number} X {multiplier} = {product}");
            }

            for (int i = multiplier; i <= 10; i++)
            {
                product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}