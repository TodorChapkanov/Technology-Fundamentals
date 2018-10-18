namespace _06_EvenAndOddSubtraction
{
    using System;
    using System.Linq;

    public class EvenAndOddSubtraction
    {
        public static void Main()
        {
            var numbersArray = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            PrintSubtraction(numbersArray);
        }

        private static void PrintSubtraction(int[] numbersArray)
        {
            var sumOfEvenNumbers = 0;
            var sumOfOddNumbers = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] % 2 == 0)
                {
                    sumOfEvenNumbers += numbersArray[i];
                }
                else
                {
                    sumOfOddNumbers += numbersArray[i];
                }
                
            }
            var subtraction = sumOfEvenNumbers - sumOfOddNumbers;

            Console.WriteLine(subtraction);
        }
    }
}
