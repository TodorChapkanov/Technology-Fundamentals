namespace _02_IronGirder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IronGirder
    {
        public static void Main()
        {
            //  For key will keep Town and on the first index in the List will keep the fastest time for traveling
            //on the second index in the List is amount of people traveled to the town  
            var destination = new Dictionary<string, List<int>>();
            while (true)
            {
                var input = Console.ReadLine().Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Slide rule")
                {
                    break;
                }
                var town = input[0];
                var timeTraveling =input[1];
                var passengers = int.Parse(input[2]);
                if (!destination.ContainsKey(town) && timeTraveling == "ambush")
                {
                    continue;
                }
                if (destination.ContainsKey(town) && timeTraveling == "ambush")
                {
                    destination[town][0] = int.MaxValue;
                    destination[town][1] -= passengers;
                    continue;
                }
                if (!destination.ContainsKey(town) && timeTraveling != "ambush")
                {
                    destination.Add(town, new List<int> { int.MaxValue, 0 });
                }
                if (destination[town][0]> int.Parse(timeTraveling))
                {
                    destination[town][0] = int.Parse(timeTraveling);
                }
                destination[town][1] += passengers;
                
            }
            foreach (var town in destination.OrderBy(m => m.Value[0]).ThenBy(t => t.Key))
            {
                if (town.Value[0] != int.MaxValue && town.Value[1] !=0)
                {
                    Console.WriteLine($"{town.Key} -> Time: {town.Value[0]} -> Passengers: {town.Value[1]}");
                }
            }
        }
    }
}
