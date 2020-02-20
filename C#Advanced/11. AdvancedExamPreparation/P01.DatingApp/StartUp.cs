namespace P01.DatingApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            int[] malesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] femalesInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var males = new Stack<int>(malesInput);
            var females = new Queue<int>(femalesInput);

            int matches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                int currentMale = males.Peek();
                int currentFemale = females.Peek();

                if (currentMale <= 0)
                {
                    males.Pop();
                    continue;
                }

                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (currentMale % 25 == 0)
                {
                    males.Pop();

                    if (males.Count > 0)
                    {
                        males.Pop();
                    }

                    continue;
                }

                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();

                    if (females.Count > 0)
                    {
                        females.Dequeue();
                    }

                    continue;
                }

                if (currentMale == currentFemale)
                {
                    matches++;
                    males.Pop();
                    females.Dequeue();
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currentMale - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");

            string finalMales = males.Count > 0 ? string.Join(", ", males) : "none";
            Console.WriteLine($"Males left: {finalMales}");

            string finalFemales = females.Count > 0 ? string.Join(", ", females) : "none";
            Console.WriteLine($"Females left: {finalFemales}");
        }
    }
}