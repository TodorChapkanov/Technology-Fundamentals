using System;

namespace _03_Passed_Or_Failed
{
    public class Program
    {
       public  static void Main()
        {
            var gradeInput = double.Parse(Console.ReadLine());
            if (gradeInput >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
