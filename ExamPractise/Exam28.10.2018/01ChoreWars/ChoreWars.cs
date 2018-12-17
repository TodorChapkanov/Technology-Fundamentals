namespace _01ChoreWars
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class ChoreWars
    {
        public static void Main()
        {
            var dishesTime = 0;
            var cleaningTime = 0;
            var laundryTime = 0;
            while (true)
            {
                StringBuilder sb = new StringBuilder();
                var chore = Console.ReadLine();
                if (chore == "wife is happy")
                {
                    break;
                }
                Regex pattern = new Regex(@"<(?<dishes>[a-z0-9]+)>|\[(?<cleaning>[A-Z0-9]+)\]|{(?<laundry>.+)}");
                Match mathc = pattern.Match(chore);
                if (mathc.Success)
                {
                    if (mathc.Groups["dishes"].Success)
                    {
                        var dishes = mathc.Groups["dishes"].Value;
                        dishesTime += FindeTimeForCurentChores(dishes);
                    }
                    else if (mathc.Groups["cleaning"].Success)
                    {
                        var cleaning = mathc.Groups["cleaning"].Value;
                        cleaningTime += FindeTimeForCurentChores(cleaning);
                    }
                    else if (mathc.Groups["laundry"].Success)
                    {
                        var laundry = mathc.Groups["laundry"].Value;
                        laundryTime += FindeTimeForCurentChores(laundry);
                    }
                }
            }
            var totalMinutes = dishesTime + cleaningTime + laundryTime;
            Console.WriteLine($"Doing the dishes - {dishesTime} min.");
            Console.WriteLine($"Cleaning the house - {cleaningTime} min.");
            Console.WriteLine($"Doing the laundry - {laundryTime} min.");
            Console.WriteLine($"Total - {totalMinutes} min."); 


        }

        private static int FindeTimeForCurentChores(string chore)
        {
            var time = 0;
            foreach (var digit in chore)
            {
                if (char.IsDigit(digit))
                {
                    time += int.Parse(digit.ToString());
                }
            }
            return time;
        }
    }
}
