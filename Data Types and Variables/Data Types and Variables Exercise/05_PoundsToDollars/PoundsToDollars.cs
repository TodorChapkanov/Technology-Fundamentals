namespace _05_PoundsToDollars
{
    using System;


    public class PoundsToDollars
    {
        public static void Main()
        {
            var poundsInput = double.Parse(Console.ReadLine());

            var dollarsFromPounds = poundsInput * 1.31;

            Console.WriteLine($"{dollarsFromPounds:f3}");
        }
    }
}
