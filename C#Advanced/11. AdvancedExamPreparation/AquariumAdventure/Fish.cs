namespace AquariumAdventure
{
    using System.Text;

    public class Fish
    {
        public Fish(string name, string color, int fins)
        {
            this.Name = name;
            this.Color = color;
            this.Fins = fins;
        }

        public string Name { get; }

        public string Color { get; }

        public int Fins { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Fish: {this.Name}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Number of fins: {this.Fins}");

            return sb.ToString().TrimEnd();
        }
    }
}