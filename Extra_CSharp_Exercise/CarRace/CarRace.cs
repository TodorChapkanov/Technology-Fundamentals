namespace CarRace
{
    using System;
    using System.Linq;

    public class CarRace
    {
        public static void Main()
        {
            var track = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            var firstTime = 0.00;
            var secondTime = 0.00;

            for (int i = 0; i < track.Count/2; i++)
            {
                firstTime += track[i];
                if (track[i] == 0)
                {
                    firstTime *= 0.8;
                }
                var secondTrack = track.Count - 1 - i;
                secondTime+= track[secondTrack];
                if (track[secondTrack] == 0)
                {
                    secondTime *= 0.8;
                }
            }
            if (firstTime < secondTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondTime}");
            }
        }
    }
}
