using System;
using System.Collections.Generic;
using System.Linq;

namespace P16.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split().ToArray();

            string filter = Console.ReadLine();

            List<string> filters = new List<string>();

            while (filter != "Print")
            {
                string[] filterInfo = filter
                    .Split(';');

                string command = filterInfo[0];

                if (command == "Add filter")
                {
                    filters.Add($"{filterInfo[1]};{filterInfo[2]}");
                }
                else if (command == "Remove filter")
                {
                    filters.Remove($"{filterInfo[1]};{filterInfo[2]}");
                }

                filter = Console.ReadLine();
            }

            Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFilter = (name, parameter) => name.StartsWith(parameter);
            Func<string, string, bool> endsWithFilter = (name, parameter) => name.EndsWith(parameter);
            Func<string, string, bool> containsFilter = (name, parameter) => name.Contains(parameter);

            foreach (var currentFilter in filters)
            {
                string[] currentFilterInfo = currentFilter.Split(';');

                string filterType = currentFilterInfo[0];
                string parameter = currentFilterInfo[1];
                names = ApplyFilter(names, lengthFilter, startsWithFilter, endsWithFilter
                    , containsFilter, filterType, parameter);
            }

            Console.WriteLine(string.Join(" ", names));
        }

        private static string[] ApplyFilter(string[] names, Func<string, int, bool> lengthFilter, Func<string, string, bool> startsWithFilter, Func<string, string, bool> endsWithFilter, Func<string, string, bool> containsFilter, string filterType, string parameter)
        {
            if (filterType == "Starts with")
            {
                names = names.Where(name => !startsWithFilter(name, parameter)).ToArray();
            }
            else if (filterType == "Ends with")
            {
                names = names.Where(name => !endsWithFilter(name, parameter)).ToArray();
            }
            else if (filterType == "Length")
            {
                int length = int.Parse(parameter);
                names = names.Where(name => !lengthFilter(name, length)).ToArray();
            }
            else if (filterType == "Contains")
            {
                names = names.Where(name => !containsFilter(name, parameter)).ToArray();
            }

            return names;
        }
    }
}