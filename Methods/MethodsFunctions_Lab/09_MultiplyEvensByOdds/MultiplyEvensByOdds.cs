namespace _09_MultiplyEvensByOdds
{
    using System;


    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var result = MultiplyDigits(Math.Abs(number));

            Console.WriteLine(result);
        }

        private static int MultiplyDigits(int number)
        {
            var sum = GetSumOfOddDigits(number) * GetSumOfEvenDigits(number);
            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            var sum = FindOddAndEvenDigits(number, 1);
            return sum;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            var result = FindOddAndEvenDigits(number, 0);
            return result;
        }
        private static int FindOddAndEvenDigits(int number, int remainder)
        {
            int sum = 0;
            
            while (number > 0)
            {
                if (number % 2 == remainder)
                {
                    sum+= number % 10;
                }
                
                number /= 10;
                
            }
            return sum;
            
        }
    }
}
