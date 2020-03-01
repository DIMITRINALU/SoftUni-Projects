namespace Restaurant.Beverages
{
    public class Coffee : HotBeverage
    {
        private const decimal COFFEE_PRICE = 3.50m;
        private const double COFFE_MILLILITERS = 50.00;

        public Coffee(string name, double caffeine)
            : base(name, COFFEE_PRICE, COFFE_MILLILITERS)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }      
}