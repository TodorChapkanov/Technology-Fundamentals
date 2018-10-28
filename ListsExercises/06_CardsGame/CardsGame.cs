namespace _06_CardsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CardsGame
    {
        public static void Main(string[] args)
        {
            var firstHand = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            var secondHand = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            var curentFirstHand = new List<int>();
            var curentSecondHand = new List<int>();

            
            while (true)
            {
                for (int i = 0; i < firstHand.Count; i++)
                {
                    if (firstHand[i] > secondHand[i])
                    {
                        curentFirstHand.Add(firstHand[i]);
                        curentFirstHand.Add(secondHand[i]);
                    }
                    else if (firstHand[i] < secondHand[i])
                    {
                        curentSecondHand.Add(secondHand[i]);
                        curentSecondHand.Add(firstHand[i]);
                    }

                }
                firstHand.Clear();
                foreach (var item in curentFirstHand)
                {
                    firstHand.Add(item);
                }
                secondHand.Clear();
                foreach (var item in curentSecondHand)
                {
                    secondHand.Add(item);
                }
                curentFirstHand.Clear();
                curentSecondHand.Clear();

                if (firstHand.Count == 0)
                {
                    Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
                    return;
                }
                 if (secondHand.Count== 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
                    return;
                }
                if (firstHand.Count == 0)
                {
                    Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
                    return;
                }
                if (secondHand.Count == 1 && secondHand.Sum() >= firstHand.Sum())
                {
                    Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
                    return;
                }
            }
        }
    }
}
