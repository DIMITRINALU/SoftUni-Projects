namespace WildFarm.Models.Animals.Contracts
{
    using WildFarm.Models.Foods.Contracts;

    public interface IAnimal
    {
        string Name { get; }
        double Weight { get; }
        int FoodEaten { get; }

        string ProduceSound();

        void Feed(IFood food);
    }
}