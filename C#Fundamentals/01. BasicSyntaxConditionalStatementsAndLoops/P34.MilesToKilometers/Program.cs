namespace P34.MilesToKilometers
{
    using System;

    class Program
    {
        static void Main()
        {
            var distanceInMiles = double.Parse(Console.ReadLine());

            const double kilometersPerMile = 1.60934;
            var distanceInKilometers = distanceInMiles * kilometersPerMile;

            Console.WriteLine("{0:F2}", distanceInKilometers);
        }
    }
}