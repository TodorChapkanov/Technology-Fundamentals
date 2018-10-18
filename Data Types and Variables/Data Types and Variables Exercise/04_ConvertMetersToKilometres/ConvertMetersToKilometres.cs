namespace _04_ConvertMetersToKilometres
{
    using System;


    public class ConvertMetersToKilometres
    {
        public static void Main()
        {
            var metersToConvert = double.Parse(Console.ReadLine());
            var convertedKilometres = metersToConvert / 1000.00;

            Console.WriteLine($"{convertedKilometres:f2}");
        }
    }
}
