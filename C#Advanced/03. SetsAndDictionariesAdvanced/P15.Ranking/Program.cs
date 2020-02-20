using System;
using System.Collections.Generic;
using System.Linq;

namespace P15.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var contests = new Dictionary<string, string>();
            var students = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                string[] command = input.Split(':');
                string contest = command[0];
                string password = command[1];

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, password);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] command = input.Split("=>");
                string contestName = command[0];
                string contestPassword = command[1];
                string username = command[2];
                int points = int.Parse(command[3]);

                if (!contests.ContainsKey(contestName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (contests[contestName] != contestPassword)
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (!students.ContainsKey(username))
                {
                    students.Add(username, new Dictionary<string, int>());
                }

                if (!students[username].ContainsKey(contestName))
                {
                    students[username].Add(contestName, points);
                }

                if (students[username][contestName] < points)
                {
                    students[username][contestName] = points;
                }

                input = Console.ReadLine();
            }

            var bestCandidate = students
                .OrderByDescending(x => x.Value.Sum(s => s.Value))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Sum(x => x.Value)} points.");
            Console.WriteLine("Ranking: ");

            foreach (var (student, allContests) in students.OrderBy(x => x.Key))
            {
                Console.WriteLine(student);

                foreach (var (contestName, points) in allContests.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contestName} -> {points}");
                }
            }
        }
    }
}