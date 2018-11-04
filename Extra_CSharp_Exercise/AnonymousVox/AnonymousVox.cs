namespace AnonymousVox
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class AnonymousVox
    {
        public static void Main()
        {
            var nameAndDatakey = new Dictionary<string, Dictionary<string, long>>();
            var cache = new Dictionary<string, Dictionary<string, long>>();

            
            

            while (true)
            {
                var data = Console.ReadLine().Split(new char[] { ' ', '|', '-', '>' },StringSplitOptions.RemoveEmptyEntries);
                if (data[0] == "thetinggoesskrra")
                {
                    break; ;
                }
                if (data.Length == 1)
                {
                    nameAndDatakey.Add(data[0], new Dictionary<string, long>());
                }
                else
                {
                    if (nameAndDatakey.ContainsKey(data[2]))
                    {
                        nameAndDatakey[data[2]].Add(data[0], long.Parse(data[1]));
                    }
                    else
                    {
                        if (!cache.ContainsKey(data[2]))
                        {
                            cache.Add(data[2], new Dictionary<string, long>());
                        }
                        cache[data[2]].Add(data[0], int.Parse(data[1]));
                    }
                }
            }
            if (nameAndDatakey.Count == 0)
            {
                return;
            }
            foreach (var item in cache)
            {
                if (nameAndDatakey.ContainsKey(item.Key))
                {
                    foreach (var size in item.Value)
                    {
                        nameAndDatakey[item.Key].Add(size.Key, size.Value);
                    }
                }
            }
            long bestSum = 0;
            var bestKey = "";
            long CurentSum = 0;
            var names = new List<string>();
            foreach (var item in nameAndDatakey)
            {
                foreach (var nested in item.Value)
                {
                    
                   long number = nested.Value;
                    CurentSum += number;
                    
                }
                if (CurentSum > bestSum)
                {
                    bestSum = CurentSum;
                    bestKey = item.Key;

                }
                CurentSum = 0;
            }
            Console.WriteLine($"Data Set: {bestKey}, Total Size: {bestSum}");
            foreach (var item in nameAndDatakey[bestKey])
            {
                Console.WriteLine($"$.{item.Key}");
            }
        }

    }
}
