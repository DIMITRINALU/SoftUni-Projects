namespace BorderControl.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BorderControl.Contracts;

    public class Engine : IEngine
    {
        private readonly List<IBuyer> foodBuyers;

        public Engine()
        {
            this.foodBuyers = new List<IBuyer>();
        }

        public void Run()
        {
            CollectBuyersInfo(foodBuyers);

            BuyFood(foodBuyers);

            int totalFoodAmount = foodBuyers.Sum(b => b.Food);

            Console.WriteLine(totalFoodAmount);
        }

        private static void BuyFood(List<IBuyer> foodBuyers)
        {
            string buyer = Console.ReadLine();

            while (buyer != "End")
            {
                var foodBuyer = foodBuyers.FirstOrDefault(x => x.Name == buyer);

                if (foodBuyer != null)
                {
                    foodBuyer.BuyFood();
                }

                buyer = Console.ReadLine();
            }
        }

        private static void CollectBuyersInfo(List<IBuyer> foodBuyers)
        {
            var peopleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < peopleCount; i++)
            {
                var infoArgs = Console.ReadLine().Split();

                if (infoArgs.Length == 4)
                {
                    foodBuyers.Add(new Citizen(infoArgs[0], int.Parse(infoArgs[1]), infoArgs[2], infoArgs[3]));
                }
                else if (infoArgs.Length == 3)
                {
                    foodBuyers.Add(new Rebel(infoArgs[0], int.Parse(infoArgs[1]), infoArgs[2]));
                }
            }
        }
    }
}      