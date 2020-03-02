namespace Person
{
    using System;
    using System.Text;

    public class Person
    {
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public virtual int Age
        {
            get => this.age;
            set
            {
                if (value >= 0)
                {
                    this.age = value;
                }                
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {this.Name}, Age: {this.Age}");

            return sb.ToString().TrimEnd();
        }
    }
}