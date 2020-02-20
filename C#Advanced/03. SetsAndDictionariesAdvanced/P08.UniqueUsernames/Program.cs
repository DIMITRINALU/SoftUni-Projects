using System;
using System.Collections.Generic;

namespace P08.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var usernames = new HashSet<string>();

            for (int i = 0; i < input; i++)
            {
                string username = Console.ReadLine();

                usernames.Add(username);
            }

            foreach (var username in usernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}