namespace _05_AddAndSubtract
{
    using System;


    public class AddAndSubtract
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var sumOfFirstAndSecondNumber = GetSumOfFirstAndSecondNumber(firstNumber, secondNumber);

            int subtractOfSumAndThirdNumber = GetSubtractOfSumAndThirdNumber(sumOfFirstAndSecondNumber, thirdNumber);

            Console.WriteLine(subtractOfSumAndThirdNumber);
        }

        private static int GetSubtractOfSumAndThirdNumber(int gerSumOfFirstAndSecondNumber, int thirdNumber)
        {
            var result = gerSumOfFirstAndSecondNumber - thirdNumber;
            return result;
        }

        private static int GetSumOfFirstAndSecondNumber(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }
    }
}
