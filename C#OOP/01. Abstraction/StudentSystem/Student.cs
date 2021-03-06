﻿using System.Text;

namespace StudentSystem
{  
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }    
        
        public string Name { get; set; }

        public int Age { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            var student = new StringBuilder();

            student.Append($"{this.Name} is {this.Age} years old.");

            if (this.Grade >= 5.00)
            {
                student.Append(" Excellent student.");
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                student.Append(" Average student.");
            }
            else
            {
                student.Append(" Very nice person.");
            }

            return student.ToString();
        }
    }
}