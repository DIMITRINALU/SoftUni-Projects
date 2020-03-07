namespace P47.CountTheIntegers
{
    using System;

    class Program
    {
        static void Main()
        {
            int numCount = 0;

            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                    numCount++;

                }
                catch (OverflowException)
                {
                    break;
                }
                catch (FormatException)
                {
                    break;
                }
            }

            Console.WriteLine(numCount);
        }
    }
}