namespace CarsSalesman
{
    using System;    
    using System.Text;

    class Car   
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;           
        }

        public Car(string model, Engine engine, int? weight)
            : this(model, engine)
        {            
            this.Weight = weight;            
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {           
            this.Color = color;
        }

        public Car(string model, Engine engine, int? weight, string color)
            : this(model, engine)
        {            
            this.Weight = weight;
            this.Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int? Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"{this.Model}:")
                .AppendLine($"  {this.Engine}")
                .AppendLine($"  Weight: {(this.Weight.HasValue ? this.Weight.ToString() : "n/a")}")
                .AppendLine($"  Color: {(String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color)}");

            return sb.ToString().TrimEnd();
        }
    }
}