namespace P03.SumOfCoins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(": ");

            var spletedInput = input[1].Split(", ");
            int[] availableCoins = new int[spletedInput.Length];

            for (int i = 0; i < spletedInput.Length; i++)
            {
                availableCoins[i] = int.Parse(spletedInput[i]);
            }

            string[] secondInput = Console.ReadLine().Split(": ");
            int targetSum = int.Parse(secondInput[1]);                      

            var sortedCoins = availableCoins
                .OrderByDescending(c => c)
                .ToList();

            int currentSum = 0;
            int counter = 0;

            var chosenCoins = new Dictionary<int, int>();

            while (currentSum != targetSum && counter < sortedCoins.Count)
            {
                var currentCoinValue = sortedCoins[counter];

                var remainingSum = targetSum - currentSum;
                var numberOdCoinsToTake = remainingSum / currentCoinValue;

                if (numberOdCoinsToTake > 0)
                {
                    chosenCoins.Add(currentCoinValue, numberOdCoinsToTake);
                    currentSum += numberOdCoinsToTake* currentCoinValue;
                }

                counter++;
            }

            if (currentSum == targetSum)
            {
                Console.WriteLine($"Number of coins to take: {chosenCoins.Values.Sum()}");

                foreach (var selectedCoin in chosenCoins)
                {
                    Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
                }               
            }
            else
            {
                Console.WriteLine("Error");
            }
        }        
    }
}