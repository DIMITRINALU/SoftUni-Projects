namespace P09.SumOfOddNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;            

            for (int i = 1; i < number * 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}