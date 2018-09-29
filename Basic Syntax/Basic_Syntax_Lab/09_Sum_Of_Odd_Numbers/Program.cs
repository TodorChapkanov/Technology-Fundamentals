using System;

namespace _09_Sum_Of_Odd_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var oddNumbersToPrint = int.Parse(Console.ReadLine());
            var oddNumbers = 1;
            var sumOfOddNumbers = 0;

            for (int i = 0; i < oddNumbersToPrint; i++)
            {
                Console.WriteLine(oddNumbers);
                sumOfOddNumbers += oddNumbers;
                oddNumbers += 2;
            }
            Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}
