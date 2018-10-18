namespace _03_RoundingNumbers
{
    using System;
    using System.Linq;

    public class RoundingNumbers
    {
        public static void Main()
        {
            var numbersInput = Console.ReadLine().
                Split().
                Select(double.Parse).
                ToArray();

            PrintRoundedNumbers(numbersInput);
        }


        public static void PrintRoundedNumbers(double[] numbersInput)
        {
            var numbesAwayFromZero = new int[numbersInput.Length];
            for (int i = 0; i < numbersInput.Length; i++)
            {
                numbesAwayFromZero[i] =(int) Math.Round(numbersInput[i],MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < numbersInput.Length; i++)
            {
                Console.WriteLine($"{numbersInput[i]} => {numbesAwayFromZero[i]}");
            }
        }
    }
}
