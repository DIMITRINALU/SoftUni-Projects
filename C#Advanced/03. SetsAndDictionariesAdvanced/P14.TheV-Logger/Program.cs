using System;
using System.Collections.Generic;
using System.Linq;

namespace P14.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggersWithFollowers  = new Dictionary<string, SortedSet<string>>();
            var vloggersWithFollowings = new Dictionary<string, HashSet<string>>();
            string commands = Console.ReadLine();

            while (commands != "Statistics")
            {
                string[] input = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[1];

                if (command == "joined")
                {
                    string vloggername = input[0];

                    if (!vloggersWithFollowers.ContainsKey(vloggername))
                    {
                        vloggersWithFollowers.Add(vloggername, new SortedSet<string>());
                        vloggersWithFollowings.Add(vloggername, new HashSet<string>());                        
                    }
                }
                else if (command == "followed")
                {
                    string followed = input[0];
                    string followers = input[2];

                    if (followed != followers)
                    {
                        if (vloggersWithFollowers.ContainsKey(followed) && vloggersWithFollowers.ContainsKey(followers))
                        {
                            vloggersWithFollowers[followers].Add(followed);
                            vloggersWithFollowings[followed].Add(followers);
                        }
                    }                    
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggersWithFollowers.Count} vloggers in its logs.");

            var sortedVloggersWithFollowers = vloggersWithFollowers
                .OrderByDescending(kvp => kvp.Value.Count)
                .ThenBy(kvp => vloggersWithFollowings[kvp.Key].Count)
                .ToDictionary(a => a.Key, b => b.Value);

            int counter = 0;

            foreach (var (vlogger, people) in sortedVloggersWithFollowers)
            {                 
                Console.WriteLine($"{++counter}. {vlogger} : {people.Count} followers, {vloggersWithFollowings[vlogger].Count} following");

                foreach (var item in people)
                {
                    if (counter == 1)
                    {
                        Console.WriteLine($"*  {item}");
                    }                    
                }
            }
        }
    }
}