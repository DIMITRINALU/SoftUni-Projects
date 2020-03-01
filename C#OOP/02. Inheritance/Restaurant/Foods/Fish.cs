namespace Restaurant.Foods
{
    public class Fish : MainDish
    {
        private const double FISH_GRAMS = 22.00;

        public Fish(string name, decimal price)
            : base(name, price, FISH_GRAMS)
        {
            
        }
    }
}