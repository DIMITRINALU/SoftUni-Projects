using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string command = Console.ReadLine();

            while (!command.Equals("Revision"))
            {
                string[] productsInfo = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = productsInfo[0];
                string products = productsInfo[1];
                double price = double.Parse(productsInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }

                if (!shops[shop].ContainsKey(products))
                {
                    shops[shop].Add(products, price);
                }               

                command = Console.ReadLine();
            }

            foreach (var (shop, products) in shops.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{shop}->");

                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }  
        }
    }
}