namespace _06_ListManipulationAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ListManipulationAdvanced
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().
               Split().
               Select(double.Parse).
               ToList();
            var secondList = new List<double>();
            bool isChanged = false;
            foreach (var numbre in numbers)
            {
                secondList.Add(numbre);
            }
            while (true)
            {
                var commands = Console.ReadLine();
                if (commands == "end")
                {
                    break;
                }
                var command = commands.Split();

                switch (command[0])
                {
                    case "Add":
                        var numberToAdd = int.Parse(command[1]);
                        secondList.Add(numberToAdd);
                        isChanged = true;
                        break;

                    case "Remove":
                        var numberToRemove = int.Parse(command[1]);
                        secondList.Remove(numberToRemove);
                        isChanged = true;
                        break;

                    case "RemoveAt":
                        var indexToRemove = int.Parse(command[1]);
                        secondList.RemoveAt(indexToRemove);
                        isChanged = true;
                        break;

                    case "Insert":
                        var numberToInsert = int.Parse(command[1]);
                        var index = int.Parse(command[2]);
                        secondList.Insert(index, numberToInsert);
                        isChanged = true;
                        break;

                    case "Contains":
                        var number = int.Parse(command[1]);
                        var result = secondList.Contains(number);
                        PrinteResult(result);
                        break;

                    case "PrintEven":
                        var remainder = 0;
                        PrinteEvennOddUmbers(secondList, remainder);
                        break;

                    case "PrintOdd":
                        remainder = 1;
                        PrinteEvennOddUmbers(secondList, remainder);
                        break;

                    case "GetSum":
                        var sum = secondList.Sum();
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        List<double> results = GetFilteredNumbers(secondList, command);
                        Console.WriteLine(string.Join(" ", results));
                        break;
                }
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", secondList));
            }
            
        }

        private static List<double> GetFilteredNumbers(List<double> secondList, string[] command)
        {
            var number = int.Parse(command[2]);
            var result = new List<double>();
            switch (command[1])
            {
                case "<":
                    for (int i = 0; i < secondList.Count; i++)
                    {
                        if (secondList[i] < number)
                        {
                            result.Add(secondList[i]);
                        }
                    }
                    break;

                case ">":
                    for (int i = 0; i < secondList.Count; i++)
                    {
                        if (secondList[i] > number)
                        {
                            result.Add(secondList[i]);
                        }
                    }
                    break;

                case ">=":
                    for (int i = 0; i < secondList.Count; i++)
                    {
                        if (secondList[i] >= number)
                        {
                            result.Add(secondList[i]);
                        }
                    }
                    break;

                case "<=":
                    for (int i = 0; i < secondList.Count; i++)
                    {
                        if (secondList[i] <= number)
                        {
                            result.Add(secondList[i]);
                        }
                    }
                    break;

            }
            return result;
        }

        private static void PrinteEvennOddUmbers(List<double> secondList, int remainder)
        {
            for (int i = 0; i < secondList.Count; i++)
            {
                if (secondList[i] % 2 == remainder)
                {
                    Console.Write(secondList[i] + " ");
                }
            }
            Console.WriteLine();
        }

        private static void PrinteResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
