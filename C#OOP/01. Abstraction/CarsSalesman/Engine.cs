namespace CarsSalesman
{
    using System;
    using System.Text;

    class Engine
    { 
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

        public string Efficiency { get; set; }        

        public int? Displacement { get; set; }        

        public int Power { get; set; }        

        public string Model { get; set; }        

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