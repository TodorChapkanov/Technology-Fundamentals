namespace _05_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Students
    {
        public class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string City { get; set; }
        }

        public static void Main()
        {
            var listOfStudents = new List<Student>();
            while (true)
            {
                var students = Console.ReadLine().Split();

                if (students[0] == "end")
                {
                    break;
                }
               
                    var firstName = students[0];
                    var lastName = students[1];
                    var age = int.Parse(students[2]);
                    var city = students[3];
                var student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city

                };
                listOfStudents.Add(student);
            }
            var town = Console.ReadLine();

            foreach (var student in listOfStudents.Where(x => x.City == town))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}
