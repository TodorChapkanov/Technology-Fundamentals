using System;

namespace _02_Passed
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gradeInput = double.Parse(Console.ReadLine());
            if (gradeInput>=3.00)
            {
                Console.WriteLine("Passed!");
            }
        }
    }
}
