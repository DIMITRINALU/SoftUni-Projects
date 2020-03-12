namespace ShoppingSpree.Core
{
    using ShoppingSpree.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();
            AddProduct();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string personName = commandArgs[0];
                string productName = commandArgs[1];

                try
                {
                    Person person = this.people
                        .First(p => p.Name == personName);
                    Product product = this.products
                        .First(p => p.Name == productName);

                    person.BuyProduct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                command = Console.ReadLine();
            }

            foreach (Person person in this.people)
            {
                Console.WriteLine(person);
            }
        }

        private void AddProduct()
        {
            string[] productArgs = Console.ReadLine()
                                        .Split(';', StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

            for (int i = 0; i < productArgs.Length; i++)
            {
                string[] currentProductTokens = productArgs[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = currentProductTokens[0];
                decimal cost = decimal.Parse(currentProductTokens[1]);

                Product product = new Product(name, cost);
                this.products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] peopleArgs = Console.ReadLine()
                            .Split(';', StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            for (int i = 0; i < peopleArgs.Length; i++)
            {
                string[] currentPeopleTokens = peopleArgs[i]
                    .Split('=', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = currentPeopleTokens[0];
                decimal money = decimal.Parse(currentPeopleTokens[1]);

                Person person = new Person(name, money);
                this.people.Add(person);
            }
        }
    }
}