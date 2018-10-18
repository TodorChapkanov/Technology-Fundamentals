namespace _07_MathPower
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            var number = double.Parse(Console.ReadLine());
            var numberPower = int.Parse(Console.ReadLine());

            var result = CalculateMathPower(number, numberPower);
            Console.WriteLine(result);
        }

        private static object CalculateMathPower(double number, int numberPower)
        {
            var numPow = number;
            for (int i = 1; i < numberPower; i++)
            {
                numPow *= number;
            }
            return numPow;
        }
    }
}
