namespace GreedyTimes
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private readonly List<Item> bag;
        private long currentAmount;

        public Bag(long capacity)
        {
            this.Capacity = capacity;
            this.bag = new List<Item>();
        }

        public long Capacity { get; set; }       

        public long GoldAmount
        {
            get
            {
                return bag.Where(i => i is Gold).Sum(i => i.Amount);
            }
        }

        public long CashAmount
        {
            get
            {
                return bag.Where(i => i is Cash).Sum(i => i.Amount);
            }
        }

        public long GemAmount
        {
            get
            {
                return bag.Where(i => i is Gem).Sum(i => i.Amount);
            }
        }

        public long CurrentAmount { get => currentAmount; set => currentAmount = value; }

        public void AddGold(Gold item)
        {
            if (this.Capacity >= currentAmount + item.Amount)
            {
                var goldItems = GetGold();

                if (goldItems.Any(g => g.Type == item.Type))
                {
                    goldItems.Single(g => g.Type == item.Type).AddAmount(item.Amount);
                }
                else
                {
                    bag.Add(item);
                }

                CurrentAmount += item.Amount;
            }
        }

        public void AddGem(Gem item)
        {
            if (this.Capacity >= currentAmount + item.Amount && GoldAmount >= GemAmount + item.Amount)
            {
                var gemItems = GetGem();

                if (gemItems.Any(g => g.Type == item.Type))
                {
                    gemItems.Single(g => g.Type == item.Type).AddAmount(item.Amount);
                }
                else
                {
                    bag.Add(item);
                }

                CurrentAmount += item.Amount;
            }
        }

        public void AddCash(Cash item)
        {
            if (this.Capacity >= currentAmount + item.Amount && GemAmount >= CashAmount + item.Amount)
            {
                var cashItems = GetCash();

                if (cashItems.Any(g => g.Type == item.Type))
                {
                    cashItems.Single(g => g.Type == item.Type).AddAmount(item.Amount);
                }
                else
                {
                    bag.Add(item);
                }

                CurrentAmount += item.Amount;
            }
        }

        public List<Item> GetCash()
        {
            return bag.Where(i => i is Cash).ToList();
        }

        public List<Item> GetGold()
        {
            return bag.Where(i => i is Gold).ToList();
        }

        public List<Item> GetGem()
        {
            return bag.Where(i => i is Gem).ToList();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var dictionary = bag.GroupBy(i => i.GetType().Name).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var kvp in dictionary.OrderByDescending(kv => kv.Value.Sum(i => i.Amount)))
            {
                if (kvp.Key == "Cash")
                {
                    sb.AppendLine($"<Cash> ${kvp.Value.Sum(i => i.Amount)}");
                }
                else if (kvp.Key == "Gem")
                {
                    sb.AppendLine($"<Gem> ${kvp.Value.Sum(i => i.Amount)}");
                }
                else if (kvp.Key == "Gold")
                {
                    sb.AppendLine($"<Gold> ${kvp.Value.Sum(i => i.Amount)}");
                }

                foreach (var item in kvp.Value.OrderByDescending(i => i.Type).ThenBy(i => i.Amount))
                {
                    sb.AppendLine($"##{item.Type} - {item.Amount}");
                }
            }

            return sb.ToString().TrimEnd(); ;
        }
    }
}