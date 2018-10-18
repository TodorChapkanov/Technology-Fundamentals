
namespace _07_LowerOrUpper
{
    using System;

    public class LowerOrUpper
    {
        public static void Main()
        {
            var charToCheck = char.Parse(Console.ReadLine());

            if (65<= charToCheck && charToCheck<=90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
