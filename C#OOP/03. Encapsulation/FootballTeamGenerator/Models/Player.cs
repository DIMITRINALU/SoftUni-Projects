namespace FootballTeamGenerator.Models
{
    using System;

    using FootballTeamGenerator.Common;

    public class Player
    {
        private string name;       
       
        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.EmptyNameException);
                }

                this.name = value;
            }
        }

        public Stats Stats { get; }

        public double OverallSkill =>
            this.Stats.AverageStat;

    }
}