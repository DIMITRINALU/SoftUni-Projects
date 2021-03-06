﻿namespace P40.ChooseADrink2._0
{
    using System;

    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double price;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70;
                    break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00;
                    break;
                case "SoftUni Student":
                    price = 1.70;
                    break;
                default:
                    price = 1.20;
                    break;
            }

            double orderValue = quantity * price;
            Console.WriteLine($"The {profession} has to pay {orderValue:F2}.");
        }
    }
}