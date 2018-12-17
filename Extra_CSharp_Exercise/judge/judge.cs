namespace judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Judge
    {
        public static void Main()
        {
            var contests = new Dictionary<string, Dictionary<string, int>>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "no more time")
                {
                    break;
                }
                var splittedINput = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var curentContest = splittedINput[1];
                var user = splittedINput[0];
                var score = int.Parse(splittedINput[2]);

                if (!contests.ContainsKey(curentContest))
                {
                    contests.Add(curentContest, new Dictionary<string, int>());
                    contests[curentContest].Add(user, score);
                }
                else if (contests.ContainsKey(curentContest) && !contests[curentContest].ContainsKey(user))
                {
                    contests[curentContest].Add(user, score);
                }
                else
                {
                    if (contests[curentContest][user]< score)
                    {
                        contests[curentContest][user] = score;
                    }
                }
            }
            
            var usersStandings = new Dictionary<string, int>();
            foreach (var item in contests)
            {
                var count = 1;
                Console.WriteLine($"{item.Key}: {item.Value.Count()} participants");
                foreach (var user in item.Value.OrderByDescending(u => u.Value).ThenBy(x => x.Key))
                {
                    
                    Console.WriteLine($"{count}. {user.Key} <::> { user.Value}");
                    count++;
                    if (!usersStandings.ContainsKey(user.Key))
                    {
                        usersStandings.Add(user.Key, user.Value);
                    }
                    else if (usersStandings.ContainsKey(user.Key))
                    {
                        usersStandings[user.Key] += user.Value;
                    }
                }
            }
            Console.WriteLine("Individual standings:");
            

           
            var i = 1;
            foreach (var user in usersStandings.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{i}. {user.Key} -> {user.Value}");
                i++;
            }
        }
    }
}
