using System;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int? displacement)
            : this(model, power)
        {
            this.Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int? displacement, string efficiency)
            : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public int? Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"    Power: {this.Power}")
                .AppendLine($"    Displacement: {(this.Displacement.HasValue ? this.Displacement.ToString() : "n/a")}")                
                .AppendLine($"    Efficiency: {(String.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency.ToString())}");

            return sb.ToString().TrimEnd();
        }
    }
}