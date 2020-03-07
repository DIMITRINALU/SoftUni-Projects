﻿namespace P41.RestaurantDiscount
{
    using System;

    class Program
    {
        static void Main()
        {
            var groupSize = int.Parse(Console.ReadLine());
            var servicePckage = Console.ReadLine();

            int servicePrice = 0;

            switch (servicePckage)
            {
                case "Normal":
                    servicePrice = 500;
                    break;
                case "Gold":
                    servicePrice = 750;
                    break;
                case "Platinum":
                    servicePrice = 1000;
                    break;
            }

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (groupSize <= 50)
            {
                var hallName = "Small Hall";
                var hallPrice = 2500;
                OutputPriceOffer(groupSize, servicePckage, servicePrice, hallName, hallPrice);
                return;
            }

            if (groupSize <= 100)
            {
                var hallName = "Terrace";
                var hallPrice = 5000;
                OutputPriceOffer(groupSize, servicePckage, servicePrice, hallName, hallPrice);
            }
            else 
            {
                var hallName = "Great Hall";
                var hallPrice = 7500;
                OutputPriceOffer(groupSize, servicePckage, servicePrice, hallName, hallPrice);
            }
        }

        static int ServicePckageDiscount(string servicePckage)
        {
            int discount = 0;

            switch (servicePckage)
            {
                case "Normal":
                    discount = 5;
                    break;
                case "Gold":
                    discount = 10;
                    break;
                case "Platinum":
                    discount = 15;
                    break;
            }

            return discount;
        }

        static void OutputPriceOffer(int groupSize, string servicePckage, int servicePrice, string hallName, int hallPrice)
        {
            var price = hallPrice + servicePrice;
            var discount = price * ServicePckageDiscount(servicePckage) / 100.0;
            var totalPrice = price - discount;
            var pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
        }
    }
}