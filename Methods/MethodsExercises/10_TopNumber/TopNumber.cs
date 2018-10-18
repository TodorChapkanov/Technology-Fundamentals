namespace _10_TopNumber
{
    using System;


    public class TopNumber
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            for (int i = 8; i < range; i++)
            {
                int num = i;

                bool isSumEquals8 = IsSumEquals8(i);
                bool isOddDigit = IsOddDigit(i);

                if (isSumEquals8 == true && isOddDigit == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsOddDigit(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsSumEquals8(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;

                sum += digit;



            }


            if (sum % 8 == 0)
            {
                return true;
            }
            return false;

        }
    }
}
