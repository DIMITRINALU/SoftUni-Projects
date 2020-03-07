namespace P20.VendingMachine
{
    using System;

    class Program
    {
        static void Main()
        {           
            string command = Console.ReadLine();            
            decimal money = 0;            

            while (command != "Start")
            {
                decimal coins = decimal.Parse(command);

                switch (coins)
                {
                    case 0.1m:
                    case 0.2m:
                    case 0.5m:
                    case 1.0m:
                    case 2.0m:
                        money += coins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coins}");
                        break;
                }

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();
            decimal productPrice = 0;            

            while (product != "End")
            {               
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2.0m;  
                        break;
                    case "Water":
                        productPrice = 0.7m;                        
                        break;
                    case "Crisps":
                        productPrice = 1.5m;                        
                        break;
                    case "Soda":
                        productPrice = 0.8m;                        
                        break;
                    case "Coke":
                        productPrice = 1.0m;                        
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;                        
                }

                if (money >= productPrice && money > 0 && productPrice > 0)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    money -= productPrice;
                    productPrice = 0; 
                }
                else if (productPrice > 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    productPrice = 0;
                }                

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {money:F2}");
        }     
    }
}