namespace _02_MeTubeStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MeTubeStatistics
    {
        public static void Main()
        {
            var statDictionary = new Dictionary<string, List<int>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stats time")
                {
                    break;
                }

                if (input.Contains('-'))
                {
                    var splitedInput = input.Split('-');
                    if (!statDictionary.ContainsKey(splitedInput[0]))
                    {
                        statDictionary.Add(splitedInput[0], new List<int> { 0, 0 });
                        
                    }
                    // The first index of the list is views and the second index is likes

                    statDictionary[splitedInput[0]][0] += int.Parse(splitedInput[1]);

                }
                if (input.Contains(':'))
                {
                    var splitedInput = input.Split(':');
                    if (statDictionary.ContainsKey(splitedInput[1]))
                    {
                        if (splitedInput[0] == "like")
                        {
                            statDictionary[splitedInput[1]][1] += 1;
                        }
                        else
                        {
                            statDictionary[splitedInput[1]][1] -= 1;
                        }
                    }
                }
            }
            var orderBy = Console.ReadLine();

            if (orderBy == "by likes")
            {
                foreach (var item in statDictionary.OrderByDescending(v => v.Value[1]))
                {
                    Console.WriteLine($"{item.Key} - {item.Value[0]} views - {item.Value[1]} likes");
                }
            }
            else 
            {
                foreach (var item in statDictionary.OrderByDescending(v=> v.Value[0]))
                {
                    Console.WriteLine($"{item.Key} - {item.Value[0]} views - {item.Value[1]} likes");
                }
            }
        }
    }
}
