
namespace _08_Snowballs
{
    using System;
    using System.Numerics;

    public class Snowballs
    {
        public static void Main()
        {
            var numberOfSnowballs = int.Parse(Console.ReadLine());
            BigInteger curenValue = 0;
            BigInteger biggestValue = 0;
            var bestSnowballsSnow = 0;
            var bestSnowballsTime = 0;
            var bestSnowballsQuality = 0;

            

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                var snowballSnow = int.Parse(Console.ReadLine());
                var snowballTime = int.Parse(Console.ReadLine());
                var snowballQuality = int.Parse(Console.ReadLine());
                curenValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);

                if (biggestValue <=curenValue)
                {
                    biggestValue = curenValue;
                    bestSnowballsSnow = snowballSnow;
                    bestSnowballsTime = snowballTime;
                    bestSnowballsQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballsSnow} : {bestSnowballsTime} = {biggestValue} ({bestSnowballsQuality})");
        }
    }
}
