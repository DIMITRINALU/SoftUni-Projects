namespace ComparingObjects
{
    using System; 

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            int names  = this.Name.CompareTo(other.Name);

            if (names == 0)
            {
                int ages = this.Age.CompareTo(other.Age);

                if (ages == 0)
                {
                   return this.Town.CompareTo(other.Town);
                }

                return ages;
            }

            return names;
        }
    }
}