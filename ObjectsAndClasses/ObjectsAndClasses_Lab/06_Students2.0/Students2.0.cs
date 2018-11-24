namespace _06_Students2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
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
            var students = new List<Student>();

            while (true)
            {
                var studentInput = Console.ReadLine().Split();
                var listOfStudents = new List<Student>();
                if (studentInput[0] == "end")
                {
                    break;
                }

                var firstName = studentInput[0];
                var lastName = studentInput[1];
                var age = int.Parse(studentInput[2]);
                var city = studentInput[3];

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    
                    student.Age = age;
                    student.City = city;

                }
                else
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        City = city
                    };
                    students.Add(student);
                }
            }
            var town = Console.ReadLine();

            foreach (var student in students.Where(x => x.City == town))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }


        }
        public static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        public static bool IsStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
