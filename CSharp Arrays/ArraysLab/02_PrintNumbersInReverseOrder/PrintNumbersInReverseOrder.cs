namespace _02_PrintNumbersInReverseOrder
{

    using System;
    
    public class PrintNumbersInReverseOrder
    {

        public static void Main()
        {
           var numbersCount = int.Parse(Console.ReadLine());
            PrintReverseNumbers(numbersCount);
        }

        public static void PrintReverseNumbers(int numbersCount)
        {
            var numberToRevers = new int[numbersCount];
            for (int i = 0; i < numberToRevers.Length; i++)
            {
                numberToRevers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberToRevers.Length / 2; i++)
            {
                int previousNumber = numberToRevers[i];
                int lastNumber = numberToRevers.Length - i - 1;

                numberToRevers[i] = numberToRevers[lastNumber];
                numberToRevers[lastNumber] = previousNumber;
            }
            for (int i = 0; i < numberToRevers.Length; i++)
            {
                Console.Write(numberToRevers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
