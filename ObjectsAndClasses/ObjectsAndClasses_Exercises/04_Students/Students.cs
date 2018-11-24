namespace _04_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    public class Students

    {
        public static void Main()
        {
            var studentsCount = int.Parse(Console.ReadLine());

            var listOfStudents = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                var student = Console.ReadLine().Split();

                Student newStudent = new Student()
                {
                    FirstName = student[0],
                    LastName = student[1],
                    Grade = double.Parse(student[2])
                };
                listOfStudents.Add(newStudent);
            }
            foreach (var student in listOfStudents.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
}
