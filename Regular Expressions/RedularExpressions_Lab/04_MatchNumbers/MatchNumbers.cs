namespace _04_MatchNumbers
{
    using System;
    using System.Text.RegularExpressions;


    public class MatchNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            MatchCollection numbers = Regex.Matches(input, pattern);

            foreach (Match number in numbers)
            {
                Console.Write(number.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
