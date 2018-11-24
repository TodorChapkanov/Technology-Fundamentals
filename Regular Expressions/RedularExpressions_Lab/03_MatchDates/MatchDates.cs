namespace _03_MatchDates
{
    using System;
    using System.Text.RegularExpressions;


    public class MatchDates
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            MatchCollection numbers = Regex.Matches(input, pattern);

            foreach (Match date in numbers)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
