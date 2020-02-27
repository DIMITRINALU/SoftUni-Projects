namespace StudentSystem
{    
    using System.Collections.Generic;    

    public class StudentData
    {
        public Dictionary<string, Student> Students { get; } = new Dictionary<string, Student>();

        public void AddStudent(string name, int age, double grade)
        {
            if (!this.Students.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                this.Students[name] = student;
            }
        }

        public string GetStudentDetails(string name)
        {
            if (!this.Students.ContainsKey(name))
            {
                return null;
            }

            var student = this.Students[name];

            return student.ToString();            
        }       
    }
}