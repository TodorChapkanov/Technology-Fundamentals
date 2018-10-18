namespace _03_TownInfo
{
    using System;


    public class TownInfo
    {
        public static void Main()
        {
            var nameOfTown = Console.ReadLine();
            var populationOfTown = int.Parse(Console.ReadLine());
            var areaOfTown = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {nameOfTown} has population of {populationOfTown} and area {areaOfTown} square km.");
        }
    }
}
