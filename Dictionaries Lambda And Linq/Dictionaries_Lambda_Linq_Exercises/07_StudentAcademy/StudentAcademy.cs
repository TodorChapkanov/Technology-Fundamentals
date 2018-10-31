namespace _07_StudentAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class StudentAcademy
    {
        public static void Main()
        {
            var numberOfStudents = int.Parse(Console.ReadLine());

            var studentEvaluation = new Dictionary<string, List<double>>();
            

            for (int i = 0; i < numberOfStudents; i++)
            {
                var student = Console.ReadLine();
                var evaluation = double.Parse(Console.ReadLine());
                if (!studentEvaluation.ContainsKey(student))
                {
                    studentEvaluation.Add(student,new List<double>());
                    studentEvaluation[student].Add(evaluation);
                }
                else
                {
                    studentEvaluation[student].Add(evaluation);
                }
            }
            foreach (var student in studentEvaluation.OrderByDescending(x => x.Value.Average()))
            {
                if (student.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }
                
            }
        }
    }
}
