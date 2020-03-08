namespace P02.RecursiveFactorial
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            long result = Factorial(num);

            Console.WriteLine(result);
        }

        private static long Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            return num * Factorial(num - 1);
        }
    }
}