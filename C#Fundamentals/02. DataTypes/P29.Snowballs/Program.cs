namespace P29.Snowballs
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int snowballs = int.Parse(Console.ReadLine());

            int snow = 0;
            int time = 0;
            int quality = 0;
            BigInteger highestSnowballValue = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                                
                BigInteger snowballValue = BigInteger.Pow((BigInteger)(snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                }
            }

            Console.WriteLine($"{snow} : {time} = {highestSnowballValue} ({quality})");
        }
    }
}