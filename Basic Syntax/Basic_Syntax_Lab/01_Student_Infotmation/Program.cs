using System;

namespace _01_Student_Infotmation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nameOfStudent = Console.ReadLine();
            var ageOfStudent = int.Parse(Console.ReadLine());
            var gradeOfStudent = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {nameOfStudent}, Age: {ageOfStudent}, Grade: {gradeOfStudent:f2}");
        }
    }
}
