namespace _01_SmallestOfThreeNumbers
{
    using System;

    public class SmallestOfThreeNumbers
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            PrinteSmallestNumber(firstNumber, SmallestNumberOfTwoNumbers(secondNumber, thirdNumber));
        }

        private static void PrinteSmallestNumber(int firstNumber, int SmallestNumberOfTwoNumbers)
        {
            int smallestNumber = Math.Min(firstNumber, SmallestNumberOfTwoNumbers);
            Console.WriteLine(smallestNumber);
        }

        private static int  SmallestNumberOfTwoNumbers(int secondNumber, int thirdNumber)
        {
            var smallestrNumber = Math.Min(secondNumber, thirdNumber);
            return smallestrNumber;
        }
    }
}
