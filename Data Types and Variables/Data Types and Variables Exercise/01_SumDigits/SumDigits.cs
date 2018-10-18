

namespace _01_SumDigits
{
    using System;

    public class SumDigits
    {
        public static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());
            var sumOfDigits = 0;

            while (numberInput != 0)
            {
                var singleDigit = numberInput % 10;
                numberInput /= 10;
                sumOfDigits += singleDigit;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
