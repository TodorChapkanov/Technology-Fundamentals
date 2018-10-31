namespace _06_Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Courses
    {
        public static void Main()
        {

            var nameOfcourseAndCount = new Dictionary<string, int>();
            var nameOfCourseAndStudents = new Dictionary<string, List<string>>();

            var courseName = "";
            var studentsName = "";

            while (true)
            {
                var input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "end")
                {
                    break;
                }
                courseName = input[0];
                studentsName = input[1];

                if (!nameOfCourseAndStudents.ContainsKey(courseName))
                {
                    nameOfCourseAndStudents.Add(courseName,new List<string>());
                    nameOfCourseAndStudents[courseName].Add(studentsName);
                    nameOfcourseAndCount.Add(courseName, 1);
                }
                else
                {
                    nameOfCourseAndStudents[courseName].Add(studentsName);
                    nameOfcourseAndCount[courseName]++;
                }
                

            }
            foreach (var course in nameOfcourseAndCount.OrderByDescending(c => c.Value))
            {
                Console.WriteLine($"{course.Key.Trim()}: {course.Value}");
                nameOfCourseAndStudents[course.Key].Sort();
                var count = nameOfCourseAndStudents[course.Key];
                for (int i = 0; i < nameOfCourseAndStudents[course.Key].Count; i++)
                {
                    Console.WriteLine($"-- {count[i].Trim()}");
                }
            }
        }
    }
}
