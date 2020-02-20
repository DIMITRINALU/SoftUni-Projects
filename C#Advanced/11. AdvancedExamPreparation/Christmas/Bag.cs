namespace Christmas
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private readonly List<Present> data;

        public Bag()
        {
            this.data = new List<Present>();
        }

        public Bag(string color, int capacity)
            : this()
        {            
            this.Color = color;
            this.Capacity = capacity;
        }

        public string Color { get; set; }
        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Present present)
        {
            if (!(this.data.Count >= this.Capacity))
            {
                this.data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            return this.data
                    .Remove(this.data
                    .Where(p => p.Name == name)
                    .FirstOrDefault());
        }

        public Present GetHeaviestPresent()
            => this.data.OrderBy(w => w.Weight).First();

        public Present GetPresent(string name)
            => this.data.First(p => p.Name == name);

        public string Report()
        {
            var sb = new StringBuilder();
           
            sb.AppendLine($"{this.Color} bag contains:");

            foreach (var present in this.data.Distinct())
            {
                sb.AppendLine(present.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}