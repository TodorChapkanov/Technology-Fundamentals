namespace _01_DayOfWeek
{
    using System;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main()
        {
            var dateInput = Console.ReadLine();

            var dayOfWeek = DateTime.ParseExact(dateInput, "d-M-yyyy", CultureInfo.CurrentCulture);

            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
