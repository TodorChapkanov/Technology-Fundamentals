namespace _03_Calculations
{
    using System;


    public class Calculations
    {
        public static void Main()
        {
            var operands = Console.ReadLine();
            var firstNumber = int.Parse(Console.ReadLine());
            var seconfNumber = int.Parse(Console.ReadLine());


            switch (operands)
            {
                case "add":
                    Add(firstNumber, seconfNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, seconfNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, seconfNumber);
                    break;
                case "divide":
                    Divide(firstNumber, seconfNumber);
                    break;
                    
            }
        }

        public static void Add(int firstNumber, int secondNumber)
        {
            var result = firstNumber + secondNumber;
            Console.WriteLine(result);
        }

        public static void Multiply(int firstNumber, int secondNumber)
        {
            var result = firstNumber * secondNumber;
            Console.WriteLine(result);
        }

        public static void Subtract(int firstNumber, int secondNumber)
        {
            var result = firstNumber - secondNumber;
            Console.WriteLine(result);
        }

        public static void Divide(int firstNumber, int SecondNumber)
        {
            var result = firstNumber / SecondNumber;
            Console.WriteLine(result);
        }
    }
}
