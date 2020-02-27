namespace HotelReservation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal pricePerDay = decimal.Parse(input[0]);
            int days = int.Parse(input[1]);
            string season = input[2];
            string discount = "None";

            if (input.Length == 4) discount = input[3];

            decimal price = PriceCalculator
                .GetTotalPrice(pricePerDay, days,
                Enum.Parse<Season>(season),
                Enum.Parse<Discount>(discount));

            Console.WriteLine($"{price:f2}");

        }
    }
}