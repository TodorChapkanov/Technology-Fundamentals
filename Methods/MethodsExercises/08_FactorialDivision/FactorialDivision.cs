namespace _08_FactorialDivision
{
    using System;
    using System.Numerics;


    public class FactorialDivision
    {
        public static void Main()
        {
            var firstNumber = long.Parse(Console.ReadLine());
            var secondNumber = long.Parse(Console.ReadLine());

            var firstNumberOfFactorial = GetFactorial(firstNumber);
            var secondNumberOfFactorial = GetFactorial(secondNumber);

            var divisionOfTwoFactorialNumbers = DivisionOfTwoNumbers(firstNumberOfFactorial,secondNumberOfFactorial);

            Console.WriteLine($"{divisionOfTwoFactorialNumbers:f2}");
        }

        private static decimal DivisionOfTwoNumbers(decimal firstNumberOfFactorial, decimal secondNumberOfFactorial)
        {
            decimal result = (decimal)(firstNumberOfFactorial / secondNumberOfFactorial);
            return result;
        }

        private static decimal GetFactorial(long number)
        {
            decimal numberOfFactorial = 1;
            if (number == 0)
            {
                return 1;
            }

            for (int i = 1; i <= number; i++)
            {
                numberOfFactorial *= i;
            }
            return numberOfFactorial;
        }
    }
}
