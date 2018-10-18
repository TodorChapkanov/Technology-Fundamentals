namespace _06_EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var arrayOfNumber = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            var leftSum = 0;
            var rigthSum = 0;

            if (arrayOfNumber.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < arrayOfNumber.Length; i++)
            {
                leftSum = 0;
                rigthSum = 0;

                for (int leftPosition = 0; leftPosition < i; leftPosition++)
                {
                    leftSum += arrayOfNumber[leftPosition];
                }
                for (int rigthPosition = i + 1; rigthPosition < arrayOfNumber.Length; rigthPosition++)
                {
                    rigthSum += arrayOfNumber[rigthPosition];
                }
                if (leftSum == rigthSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                else
                {
                    leftSum = 0;
                    rigthSum = 0;
                }

            }
            Console.WriteLine("no");
        }
    }
}
