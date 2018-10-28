namespace _03_BakingFactory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BakingFactory
    {
        public static void Main()
        {
            var curentQuality =int.MinValue;
            var bestQuality = int.MinValue;
            var curentAverage = 0.0;
            var bestAverage = 0.0;
            var curentLength = 0;
            var bestLength = 0;
            var istrue = false;
            var bestBreads = new List<int>();
            while (true)
            {
                var input = Console.ReadLine().ToLower();
                
                if (input.Contains("bake"))
                {
                    break;
                }
                var breads = input.Split('#', StringSplitOptions.RemoveEmptyEntries).
                    Select(int.Parse).
                    ToList();
                curentQuality = breads.Sum();
                curentAverage = breads.Average();
                curentLength = breads.Count();
                if (curentQuality >0 )
                {
                    if (curentQuality > bestQuality)
                    {
                        bestQuality = curentQuality;
                        bestAverage = curentAverage;
                        bestBreads = breads;
                        bestLength = curentLength;
                        istrue = true;
                    }

                }
                if (curentQuality <=0)
                {
                    if (curentQuality >= bestQuality)
                    {
                        bestQuality = curentQuality;
                        bestAverage = curentAverage;
                        bestBreads = breads;
                        bestLength = curentLength;
                        istrue = true;
                    }
                }
                if (curentQuality == bestQuality)
                {
                    if (curentAverage > bestAverage)
                    {
                        bestQuality = curentQuality;
                        bestBreads = breads;
                        bestLength = curentLength;
                        bestAverage = curentAverage;
                        istrue = true;
                    }
                    if (curentAverage == bestAverage)
                    {
                        if (curentLength > bestLength)
                        {
                            bestBreads = breads;
                            istrue = true;
                        }
                    }
                }
                
                   
            }
            if (istrue )
            {
                Console.WriteLine($"Best Batch quality: {bestQuality}");
                Console.WriteLine(string.Join(" ", bestBreads));
            }
            
        }
    }
}
