using System;

namespace _04_After_In_30_Minutes
{
    public class Program
    {
        public static void Main()
        {
            var hoursInput = int.Parse(Console.ReadLine());
            var minutesInput = int.Parse(Console.ReadLine());

            var time = new DateTime(1, 1, 1, hoursInput, minutesInput, 0);
            var timeBefor30Minutes = time.AddMinutes(30);

            Console.WriteLine($"{timeBefor30Minutes.Hour}:{timeBefor30Minutes.Minute:D2}");
        }
    }
}
