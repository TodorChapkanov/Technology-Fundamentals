namespace _01_DayOfWeek
{
    using System;


    public class DayOfWeek
    {
        public static void PrintDayOfWeekWithWord(int dayOfWeek)
        {
            var days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"

            };
            if (dayOfWeek <= 0 || dayOfWeek > 7 )
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[dayOfWeek-1]);
            }
        }

        public static void Main()
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            PrintDayOfWeekWithWord(dayOfWeek);
        }
    }
}
