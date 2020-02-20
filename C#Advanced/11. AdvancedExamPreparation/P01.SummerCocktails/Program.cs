namespace P01.SummerCocktails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program 
    {
        public static void Main()
        {           

            Queue<int> baskets = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> cocktailsValues = new Dictionary<string, int>
            {
                { "Mimosa", 150 },
                { "Daiquiri", 250 },
                { "Sunshine", 300 },
                { "Mojito", 400 }
            };

            Dictionary<string, int> readyCocktails = new Dictionary<string, int>
            {
                { "Mimosa", 0 },
                { "Daiquiri", 0 },
                { "Sunshine", 0 },
                { "Mojito", 0 }
            };

            while (baskets.Count > 0 && freshness.Count > 0)
            {
                int igredients = baskets.Peek();
                int fresh = freshness.Peek();

                if (igredients == 0)
                {
                    baskets.Dequeue();
                    continue;
                }

                int cocktail = igredients * fresh;

                bool isCocktail = cocktailsValues.Any(x => x.Value == cocktail);

                if (isCocktail)
                {
                    foreach (var pair in cocktailsValues)
                    {
                        if (pair.Value == cocktail)
                        {
                            string cocktailName = pair.Key;
                            readyCocktails[cocktailName]++;
                        }
                    }

                    baskets.Dequeue();
                    freshness.Pop();
                }
                else
                {
                    baskets.Enqueue(baskets.Dequeue() + 5);
                    freshness.Pop();
                }
            }

            var areAllCocktailsReady = readyCocktails.All(x => x.Value != 0);

            if (areAllCocktailsReady)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
                if (baskets.Count > 0)
                {
                    Console.WriteLine($"Ingredients left: {baskets.Sum()}");
                }
            }

            foreach (var readyCocktail in readyCocktails.OrderBy(x => x.Key))
            {
                if (readyCocktail.Value != 0)
                {
                    Console.WriteLine($"# {readyCocktail.Key} --> {readyCocktail.Value}");

                }
            }
        }
    }
}