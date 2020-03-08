namespace P27.SpiceMustFlow
{
    using System;

    class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());
            int produced = 0;
            int days = 0;

            if (startingYield < 100)
            {
                Console.WriteLine(days);
                Console.WriteLine(produced);
            }
            else
            {
                while (startingYield >= 100)
                {
                    produced += startingYield - 26;
                    startingYield -= 10;
                    days++;
                }

                produced -= 26;

                Console.WriteLine(days);
                Console.WriteLine(produced);
            }
        }
    }
}