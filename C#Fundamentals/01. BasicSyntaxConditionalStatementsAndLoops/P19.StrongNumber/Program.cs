namespace P19.StrongNumber
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int factorialSum = 0;

            while (number != 0)
            {
                int currentNumber = number % 10;
                number /= 10;
                int factorial = 1;

                for (int i = 2; i <= currentNumber; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
            }                      
            
            if (numberCopy == factorialSum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}