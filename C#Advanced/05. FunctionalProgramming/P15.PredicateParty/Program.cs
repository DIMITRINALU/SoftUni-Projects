using System;
using System.Linq;
using System.Collections.Generic;

namespace P15.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine()
                .Split()
                .ToList();

            string commands = Console.ReadLine();

            while (commands != "Party!")
            {
                string[] tokens = commands
                    .Split()
                    .ToArray();

                string command = tokens[0];
                string[] predicates = tokens
                    .Skip(1)
                    .ToArray();

                Predicate<string> predicate = GetPredicate(predicates);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else if (command == "Double")
                {
                    DoubleGuests(guests, predicate);
                }

                commands = Console.ReadLine();
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
        }

        private static void DoubleGuests(List<string> guests, Predicate<string> predicate)
        {
            for (int i = 0; i < guests.Count; i++)
            {
                string guest = guests[i];

                if (predicate(guest))
                {
                    guests.Insert(i + 1, guest);
                    i++;
                }
            }
        }

        static Predicate<string> GetPredicate(string[] predicates)
        {
            string predicateCommand = predicates[0];
            string predicateArgs = predicates[1];

            Predicate<string> predicate = null;

            if (predicateCommand == "StartsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.StartsWith(predicateArgs);
                });
            }
            else if (predicateCommand == "EndsWith")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.EndsWith(predicateArgs);
                });
            }
            else if (predicateCommand == "Length")
            {
                predicate = new Predicate<string>((name) =>
                {
                    return name.Length == int.Parse(predicateArgs);
                });
            }

            return predicate;
        }
    }
}