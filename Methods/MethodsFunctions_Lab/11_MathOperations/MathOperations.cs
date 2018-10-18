namespace _11_MathOperations
{
    using System;


    public class MathOperations
    {
        public static void Main()
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var operatorInput = char.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var result = 0.00;

            if (operatorInput == '+')
            {
                result = AddOperation(firstNumber, secondNumber);
            }
            else if (operatorInput == '*')
            {
                result = MultiplyOperation(firstNumber, secondNumber);
            }
            else if (operatorInput == '-')
            {
                result = SubtractOperation(firstNumber, secondNumber);
            }
            else if (operatorInput == '/')
            {
                result = DivideOperation(firstNumber, secondNumber);
            }

            Console.WriteLine(Math.Round(result,2));
        }

        private static double DivideOperation(double firstNumber, double secondNumber)
        {
            var result = firstNumber / secondNumber;
            return result;
        }

        private static double SubtractOperation(double firstNumber, double secondNumber)
        {
            var result = firstNumber - secondNumber;
            return result;
        }

        private static double MultiplyOperation(double firstNumber, double secondNumber)
        {
            var result = firstNumber * secondNumber;
            return result;
        }

        private static double AddOperation(double firstNumber, double secondNumber)
        {
            var result = firstNumber + secondNumber;
            return result;
        }
    }
}
