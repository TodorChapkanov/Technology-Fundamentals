namespace _02_SoftUniExamResults
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniExamResults
    {
        public static void Main()
        {
            var studens = new Dictionary<string, Dictionary<string, int>>();
            var languageSubmissions = new Dictionary<string, int>();

            while (true)
            {
                var submission = Console.ReadLine().Split('-');
                if (submission[0] == "exam finished" )
                {
                    break;
                }
                if (submission[1] == "banned")
                {
                    if (studens.ContainsKey(submission[0]))
                    {
                        studens.Remove(submission[0]);
                        continue;
                    }
                }
                var studentName = submission[0];
                var language = submission[1];
                var points = int.Parse(submission[2]);

                if (!studens.ContainsKey(studentName))
                {
                    studens.Add(studentName, new Dictionary<string, int>());
                    studens[studentName].Add(language, points);
                    
                }
                if (!languageSubmissions.ContainsKey(language))
                {
                    languageSubmissions.Add(language, 0);
                }
                languageSubmissions[language] += 1;
                if (studens.ContainsKey(studentName) && !studens[studentName].ContainsKey(language))
                {
                    studens[studentName].Add(language, points);
                    
                }
                if (studens.ContainsKey(studentName) && studens[studentName].ContainsKey(language))
                {
                    if (studens[studentName][language] < points)
                    {
                        studens[studentName][language] = points;
                    }
                    
                }


            }
            var studensSum = new Dictionary<string, int>();
            foreach (var item in studens)
            {
                foreach (var points in item.Value)
                {
                    if (!studensSum.ContainsKey(item.Key))
                    {
                        studensSum.Add(item.Key, 0);
                    }
                    studensSum[item.Key] += points.Value;
                }
            }
            Console.WriteLine("Results:");
            foreach (var item in studensSum.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languageSubmissions.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            
        }
    }
}
