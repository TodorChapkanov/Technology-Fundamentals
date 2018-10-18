
namespace _06_ReversedChars
{
    using System;

    public class ReversedChars
    {
        public static void Main()
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdChar} {secondChar} {firstChar}");
        }
    }
}
