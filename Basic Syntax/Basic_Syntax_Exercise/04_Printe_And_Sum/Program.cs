using System;

namespace _04_Print_And_Sum
{
    public class Program
    {
       

        public static void Main()
        {
            int numberToStart = int.Parse(Console.ReadLine());
            int numberToEnd = int.Parse(Console.ReadLine());
            PrinteTheNumbersAndSum(numberToStart,numberToEnd);
        }


        public static void PrinteTheNumbersAndSum (int numberToStart, int numberToEnd)
        {
            int sumOfNumbers = 0;

            for (int i = numberToStart; i <= numberToEnd; i++)
            {
                Console.Write($"{i} ");
                sumOfNumbers += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sumOfNumbers}");
        }
    }
}
