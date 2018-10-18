namespace _02_Grades
{
    using System;


    public class Grades
    {
        public static void Main()
        {
            var grade = double.Parse(Console.ReadLine());

            PrintGradeInWords(grade);
        }

        private static void PrintGradeInWords(double grade)
        {
            if (2.00 <= grade && grade < 3.00)
            {
                Console.WriteLine("Fail");
            }

            else if (3.00 <= grade && grade < 3.50)
            {
                Console.WriteLine("Poor");
            }

            else if (3.50 <= grade && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (4.50 <= grade && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else 
            {
                Console.WriteLine("Excellent");
            }
            
        }
    }
}
