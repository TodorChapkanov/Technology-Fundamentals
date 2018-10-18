namespace _07_EqualArrays
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {

            var firstArray = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            var secondArray = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            PrintEqualOrNot(firstArray, secondArray);
        }

        private static void PrintEqualOrNot(int[] firstArray, int[] secondArray)
        {
            var indexOfWrongNumbers = 0;
            var sumOfEqualArray = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sumOfEqualArray += firstArray[i];
                }
                else
                {
                    indexOfWrongNumbers = i;
                    Console.WriteLine($"Arrays are not identical. Found difference at {indexOfWrongNumbers} index");
                    return;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sumOfEqualArray}");
        }
    }
}
