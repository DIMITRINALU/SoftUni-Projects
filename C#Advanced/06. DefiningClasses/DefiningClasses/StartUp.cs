using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var listOfPeople = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] information = Console.ReadLine()
                    .Split();

                string name = information[0];
                int age = int.Parse(information[1]);
                
                listOfPeople.Add(new Person(name, age));
            }

            var sortedPeople = listOfPeople.Where(a => a.Age > 30).OrderBy(n => n.Name);

            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}