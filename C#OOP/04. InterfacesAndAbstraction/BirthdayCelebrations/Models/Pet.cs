namespace BorderControl.Models
{
    using BorderControl.Contracts;

    public class Pet : IExistable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }

        public string Name { get; private set; }

        public string BirthDate { get; private set; }
    }
}