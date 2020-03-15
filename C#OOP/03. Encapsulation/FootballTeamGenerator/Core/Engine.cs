namespace FootballTeamGenerator.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FootballTeamGenerator.Models;
    using FootballTeamGenerator.Common;

    public class Engine
    {
        private List<Team> teams;

        public Engine()
        {
            this.teams = new List<Team>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    string[] commandArgs = command.Split(';', StringSplitOptions.None).ToArray();

                    string commandType = commandArgs[0];

                    if (commandType == "Team")
                    {
                        AddTeam(commandArgs);
                    }
                    else if (commandType == "Add")
                    {
                        AddPlayerToTeam(commandArgs);
                    }
                    else if (commandType == "Remove")
                    {
                        RemovePlayer(commandArgs);
                    }
                    else if (commandType == "Rating")
                    {
                        PrintRating(commandArgs);
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);                
                }                

                command = Console.ReadLine();
            }   
        }

        private void PrintRating(string[] commandArgs)
        {
            string teamName = commandArgs[1];

            this.ValidateTeamExist(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            Console.WriteLine(team);
        }

        private void RemovePlayer(string[] commandArgs)
        {
            string teamName = commandArgs[1];
            string playerName = commandArgs[2];

            this.ValidateTeamExist(teamName);

            Team team = this.teams.First(t => t.Name == teamName);

            team.RemovePlayer(playerName);
        }

        private void AddPlayerToTeam(string[] commandArgs)
        {
            string teamName = commandArgs[1];
            string playerName = commandArgs[2];

            this.ValidateTeamExist(teamName);
            Team team = this.teams.First(t => t.Name == teamName);
            
            Stats stats = this.CreateStats(commandArgs.Skip(3).ToArray());

            Player player = new Player(playerName, stats);
            team.AddPlayer(player);
        }

        private Stats CreateStats(string[] commandArgs)
        {
            int endurance = int.Parse(commandArgs[0]);
            int sprint = int.Parse(commandArgs[1]);
            int dribble = int.Parse(commandArgs[2]);
            int passing = int.Parse(commandArgs[3]);
            int shooting = int.Parse(commandArgs[4]);

            Stats stats = new Stats(endurance, sprint, dribble, passing, shooting);

            return stats;
        }

        private void ValidateTeamExist(string name)
        {
            if (!this.teams.Any(t => t.Name == name))
            {
                throw new ArgumentException(String.Format
                    (ExceptionMessages.MissingTeamException, name));
            }
        }

        private void AddTeam(string[] commandArgs)
        {
            string teamName = commandArgs[1];

            Team team = new Team(teamName);

            this.teams.Add(team);
        }
    }
}