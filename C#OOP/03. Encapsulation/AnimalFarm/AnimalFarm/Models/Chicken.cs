namespace AnimalFarm.Models
{    
    using System;

    using AnimalFarm.Common;

    public class Chicken
    {
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 15;

        private string name;
        private int age;

        public Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < MIN_AGE || value > MAX_AGE)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidAgeExceptionMessage);
                }

                this.age = value;
            }
        }

        public double ProductPerDay => this.CalculateProductPerDay();

        public double CalculateProductPerDay()
        {
            if (this.Age <= 3)
            {
                return 1.5;
            }

            if (this.Age <= 7)
            {
                return 2;
            }

            if (this.Age <= 11)
            {
                return 1;
            }

            return 0.75;
        }
    }
}