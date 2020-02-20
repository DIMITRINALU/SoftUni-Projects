using System;
using System.Collections.Generic;

namespace P04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {            
            var continentsInfo = new Dictionary<string, Dictionary<string, List<string>>>();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = tokens[0];
                string country = tokens[1];
                string city = tokens[2];

                if (!continentsInfo.ContainsKey(continent))
                {
                    continentsInfo.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsInfo[continent].ContainsKey(country))
                {
                    continentsInfo[continent].Add(country, new List<string>());
                }

                continentsInfo[continent][country].Add(city);
            }
        
            foreach (var continent in continentsInfo)
            {    
                Console.WriteLine($"{continent.Key}:");

                foreach (var (country, city) in continent.Value)
                {
                    Console.WriteLine($"    {country} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}