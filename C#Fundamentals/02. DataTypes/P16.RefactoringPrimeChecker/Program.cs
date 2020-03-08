namespace P16.RefactoringPrimeChecker
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 2; number <= n; number++)
{
                bool IsPrime = true;

                for (int i = 2; i < number; i++)
{
                    if (number % i == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{number} -> {IsPrime.ToString().ToLower()}");
            }
        }
    }
}