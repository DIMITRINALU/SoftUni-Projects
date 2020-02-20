namespace P01.SpaceshipCrafting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            const int GlassValue = 25;
            const int AluminiumValue = 50;
            const int LithiumValue = 75;
            const int CarbonFiberValue = 100;

            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> items = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Dictionary<string, int> craftedItems = new Dictionary<string, int> 
            { { "Aluminium", 0 },
                { "Carbon fiber", 0 },
                { "Glass", 0},
                {"Lithium", 0}     
            };

            while (liquids.Count > 0 && items.Count > 0)
            {
                int currentLiquid = liquids.Dequeue();
                int currentItem = items.Pop();

                int sum = currentLiquid + currentItem;

                switch (sum)
                {
                    case GlassValue:
                        craftedItems["Glass"]++;
                        break;
                    case AluminiumValue:
                        craftedItems["Aluminium"]++;
                        break;
                    case LithiumValue:
                        craftedItems["Lithium"]++;
                        break;
                    case CarbonFiberValue:
                        craftedItems["Carbon fiber"]++;
                        break;
                    default:
                        items.Push(currentItem + 3);
                        break;
                }
            }

            if (!craftedItems.ContainsValue(0))
            {
                Console.WriteLine($"Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine($"Liquids left: none");
            }

            if (items.Any())
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine($"Physical items left: none");
            }

            foreach (var item in craftedItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}