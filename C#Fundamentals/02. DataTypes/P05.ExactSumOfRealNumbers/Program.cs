namespace P05.ExactSumOfRealNumbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());                  
            }

            Console.WriteLine(sum);
        }
    }
}