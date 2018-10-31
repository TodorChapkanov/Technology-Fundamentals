namespace _01_CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class CountRealNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var dict = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!dict.ContainsKey(number))
                {
                    dict[number] = 0;
                }
                dict[number]++;
            }
            foreach (var count in dict)
            {
                Console.WriteLine($"{count.Key} -> {count.Value}");
            }
        }
    }
}
