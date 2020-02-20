using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] input = command.Split();

                string trainerName = input[0];
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                Trainer trainer = trainers[trainerName];
                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                trainer.Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string element = command;

                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        
                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

                command = Console.ReadLine();
            }

            var collectionOfTrainers = trainers
                .OrderByDescending(x => x.Value.Badges)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in collectionOfTrainers)
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}