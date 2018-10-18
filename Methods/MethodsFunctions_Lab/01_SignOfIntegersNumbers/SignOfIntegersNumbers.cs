namespace _01_SignOfIntegersNumbers
{
    using System;


    public class SignOfIntegersNumbers
    {
        public static void Main()
        {
            var integerInput = int.Parse(Console.ReadLine());

            PrintSignOfInteger(integerInput);
        }

        private static void PrintSignOfInteger(int integerInput)
        {
            if (integerInput > 0)
            {
                Console.WriteLine($"The number {integerInput} is positive.");
            }
            else if (integerInput < 0)
            {
                Console.WriteLine($"The number {integerInput} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {integerInput} is zero.");
            }
        }
    }
}
