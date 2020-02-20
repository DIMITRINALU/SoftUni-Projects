using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDogs = int.Parse(Console.ReadLine());
            var dogs = new List<Dog>();

            for (int i = 0; i < totalDogs; i++)
            {
                var currentDog = Console.ReadLine().Split(", ");

                dogs.Add(new Dog
                {
                    Name = currentDog[0],
                    Age = int.Parse(currentDog[1])

                });
            }

            var filter = Console.ReadLine();
            var ageFilter = int.Parse(Console.ReadLine());            

            Func<Dog, bool> filterText = filter switch
            {
                "older" => c => c.Age >= ageFilter,
                "younger" => c => c.Age < ageFilter,
                _ => c => true
            };

            var output = Console.ReadLine();

            Func<Dog, string> ouputFunc = output switch
            {
                "name age"=> c => $"{c.Name} - {c.Age}",
                "name"=> c => c.Name,
                "age"=> c => c.Age.ToString(),
                _=> null
            };

            dogs.Where(filterText).Select(ouputFunc).ToList().ForEach(Console.WriteLine);
        }        
    }    
}