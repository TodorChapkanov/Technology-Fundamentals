using System;

namespace _06_Strong_Number
{
    public class Program
    {

        public static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());
            var newNumber = numberInput;
            var sumOfFactorial = 0;
            while (newNumber != 0)
            {
                var digit = newNumber % 10;
                newNumber = newNumber / 10;
                var factorial = 1;
                for (int i = 2; i <= digit; i++)
                {
                    factorial *= i;
                }
                sumOfFactorial += factorial;
            }
            if (sumOfFactorial == numberInput)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
