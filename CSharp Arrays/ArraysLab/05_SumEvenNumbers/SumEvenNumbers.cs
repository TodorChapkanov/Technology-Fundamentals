namespace _05_SumEvenNumbers
{
    using System;
    using System.Linq;

    public class SumEvenNumbers
    {
        public static void Main()
        {
            var numbersInput = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            PrintSumFromEvenNumbers(numbersInput);

        }

        public static void PrintSumFromEvenNumbers(int[] numberINput)
        {
            var sum = 0;
            for (int i = 0; i < numberINput.Length; i++)
            {
                if (numberINput[i] % 2 ==0)
                {
                    sum += numberINput[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
