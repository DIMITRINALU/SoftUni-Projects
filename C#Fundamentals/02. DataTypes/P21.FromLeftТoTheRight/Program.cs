namespace P21.FromLeftТoTheRight
{
    using System;    

    class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            
            while (lines > 0)
            {
                string numbers = Console.ReadLine();
                char delimiter = ' ';
                string[] splitNumbers = numbers.Split(delimiter);

                long leftNumbers = long.Parse(splitNumbers[0]);
                long rightNumbers = long.Parse(splitNumbers[1]);

                long biggerNumber = rightNumbers;

                if (leftNumbers > rightNumbers)
                {
                    biggerNumber = leftNumbers;
                }

                long sumOfDigits = 0;

                while (biggerNumber != 0)
                {
                    sumOfDigits += biggerNumber % 10;
                    biggerNumber /= 10;
                }

                Console.WriteLine(Math.Abs(sumOfDigits));

                lines--;
            }
        }        
    }
}