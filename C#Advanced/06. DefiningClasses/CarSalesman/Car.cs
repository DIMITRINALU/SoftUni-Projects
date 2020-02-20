using System;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

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

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int? Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
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
                .AppendLine($"  {this.Engine}")
                .AppendLine($"  Weight: {(this.Weight.HasValue ? this.Weight.ToString() : "n/a")}")
                .AppendLine($"  Color: {(String.IsNullOrEmpty(this.Color) ? "n/a" : this.Color)}");

            return sb.ToString().TrimEnd(); 
        }
    }
}