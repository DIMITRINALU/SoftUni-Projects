using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int names = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < names; i++)
            {
                string[] student = Console.ReadLine().Split();
                string name = student[0];
                decimal grade = decimal.Parse(student[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                }

                students[name].Add(grade);
            }

            foreach (var (name, grade) in students)
            {
                var allGrades = string.Join(" ", grade.Select(x => x.ToString("f2")));
                var averageGrades = grade.Average();

                Console.WriteLine($"{name} -> {allGrades} (avg: {averageGrades:f2})");
            }

            //foreach (var (name, grade) in students)
            //{    
            //    Console.Write($"{name} -> ");

            //    foreach (var gradeValue in grade)
            //    {
            //        Console.Write($"{gradeValue:f2} ");                 
            //    }

            //    Console.WriteLine($"(avg: {grade.Average():f2})");
            //}
        }
    }
}