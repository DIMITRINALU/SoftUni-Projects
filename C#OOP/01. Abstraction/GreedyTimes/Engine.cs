namespace GreedyTimes
{
    using System;    

    public class Engine
    {
        public Engine()
        {

        }

        public void Run()
        {
            long capacity = long.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Bag bag = new Bag(capacity);

            for (int i = 0; i < input.Length; i += 2)
            {
                string type = input[i];
                long amount = long.Parse(input[i + 1]);

                InsertItem(type, amount, bag);
            }

            Console.WriteLine(bag.ToString());

        }

        private static void InsertItem(string type, long amount, Bag bag)
        {
            if (type.Length == 3)
            {
                Cash cash = new Cash(type, amount);
                bag.AddCash(cash);
            }
            else if (type.Length >= 4 && type.ToLower().EndsWith("gem"))
            {
                Gem gem = new Gem(type, amount);
                bag.AddGem(gem);
            }
            else if (type.ToLower().Equals("gold"))
            {
                Gold gold = new Gold(type, amount);
                bag.AddGold(gold);
            }
        }
    }
}