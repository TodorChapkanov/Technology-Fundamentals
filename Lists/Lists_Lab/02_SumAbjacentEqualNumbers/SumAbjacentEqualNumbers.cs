namespace _02_SumAbjacentEqualNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SumAbjacentEqualNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().
                Split().
                Select(double.Parse).
                ToList();

            List<double> resultList = SumEqualNumbers(numbers);
            Console.WriteLine(string.Join(" ", resultList));
        }

        private static List<double> SumEqualNumbers(List<double> numbers)
        {
            
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    var sum = numbers[i] + numbers[i + 1];
                    numbers[i] = sum;
                    numbers.RemoveAt(i + 1);
                    i = -1;
                }
            }
            return numbers;
        }
    }
}
