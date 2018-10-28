namespace _03_Gauss_Trick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Gauss_Trick
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            var result = SumTheNumbers(numbers);
            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> SumTheNumbers(List<int> numbers)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count/2; i++)
            {
                var sum = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(sum);
            }

            if (numbers.Count % 2 !=0)
            {
                result.Add(numbers[numbers.Count / 2]);
            }
            return result;
        }
    }
}
