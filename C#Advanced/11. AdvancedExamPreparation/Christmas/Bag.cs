namespace Christmas
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bag
    {
        private  List<Present> data;               

        public Bag(string color, int capacity)            
        {
            this.data = new List<Present>();
            this.Color = color;
            this.Capacity = capacity;
        }

        public int Count => this.data.Count;
        public string Color { get; set; }
        public int Capacity { get; set; }       

        public void Add(Present present)
        {
            if (this.Capacity != 0 && !data.Contains(present))
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present present = this.data
                    .FirstOrDefault(present => present.Name == name);

            if (present != null)
            {
                this.data.Remove(present);

                return true;
            }

            return false;           
        }

        public Present GetHeaviestPresent()
        {
            int maxWeight = int.MinValue;

            Present heaviestPresent = null;

            foreach (var present in data)
            {
                if (present.Weight > maxWeight)
                {
                    heaviestPresent = present;
                }
            }

            return heaviestPresent;
        }  

        public Present GetPresent(string name)
            => this.data.First(p => p.Name == name);

        public string Report()
        {
            var sb = new StringBuilder();
           
            sb.AppendLine($"{this.Color} bag contains:");

            foreach (var present in this.data)
            {
                sb.AppendLine(present.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}