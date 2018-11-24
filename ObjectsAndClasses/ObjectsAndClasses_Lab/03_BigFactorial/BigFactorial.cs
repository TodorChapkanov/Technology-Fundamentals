namespace _03_BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger factorialNumber = 1;
            for (int i = 2; i <= number; i++)
            {
                factorialNumber *= i;
            }
            Console.WriteLine(factorialNumber);
        }
    }
}
