namespace P28.PokeMon
{
    using System;

    class Program
    {
        static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int count = 0;

            decimal halfPower = power * 0.5m;

            while (power >= distance)
            {
                power -= distance;
                count++;

                if (power == halfPower && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;
                }                  
            }

            Console.WriteLine(power);
            Console.WriteLine(count);
        }
    }
}