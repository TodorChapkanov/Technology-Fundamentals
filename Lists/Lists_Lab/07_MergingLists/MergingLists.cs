namespace _07_MergingLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class MergingLists
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            var secondList = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            var biggestList = Math.Max(firstList.Count, secondList.Count);

            var resultList = new List<int>();

            for (int i = 0; i < biggestList; i++)
            {
                if (i < firstList.Count)
                {
                    resultList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                    resultList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", resultList));

        }
    }
}
