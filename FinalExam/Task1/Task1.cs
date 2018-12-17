namespace Task1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Task1
    {
        public static void Main()
        {
            var playTime = new Dictionary<string, double>();
            var bandMembers = new Dictionary<string, List<string>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "start of concert")
                {
                    break;
                }

                var splitedInput = input.Split("; ");

                if (splitedInput[0] == "Add")
                {
                    var members = splitedInput[2].Split(", ");

                    if (!bandMembers.ContainsKey(splitedInput[1]))
                    {
                        bandMembers.Add(splitedInput[1], new List<string>());
                    }

                    for (int i = 0; i < members.Length; i++)
                    {
                        if (!bandMembers[splitedInput[1]].Contains(members[i]))
                        {
                            bandMembers[splitedInput[1]].Add(members[i]);
                        }
                    }
                }
                if (splitedInput[0] == "Play")
                {
                    
                    if (!playTime.ContainsKey(splitedInput[1]))
                    {
                        playTime.Add(splitedInput[1],0);
                    }
                    if (playTime.ContainsKey(splitedInput[1]))
                    {
                        playTime[splitedInput[1]] += double.Parse(splitedInput[2]);
                    }

                }
            }
            var timeSum = playTime.Values.Sum();
            Console.WriteLine($"Total time: {timeSum}");
            foreach (var time in playTime.OrderByDescending(t => t.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine(time.Key +" -> "+ time.Value);
            }
            var secondInput = Console.ReadLine();
            Console.WriteLine(secondInput);
            foreach (var member in bandMembers[secondInput])
            {
                Console.WriteLine("=> " + member);
            }
        }
    }
}
