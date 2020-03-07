namespace P26.GamingStore
{
    using System;

    class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double price = 0;
            double totalSpent = 0;

            while (command != "Game Time")
            {                
                string game = command;                

                switch (game)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }

                if (balance >= price) 
                {
                    Console.WriteLine($"Bought {game}");
                    balance -= price;
                    totalSpent += price;
                }                                
                else if (balance < price)
                {
                    Console.WriteLine("Too Expensive");
                }

                command = Console.ReadLine();
            }

            if (balance == 0)
            {
                Console.WriteLine("Out of money");
            }
            else
            {
                Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
            }            
        }
    }
}