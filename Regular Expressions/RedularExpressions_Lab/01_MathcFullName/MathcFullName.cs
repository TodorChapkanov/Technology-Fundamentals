namespace _01_MathcFullName
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;


    public class MathcFullName
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matchName = Regex.Matches(input, regex);

            foreach (Match name in matchName)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
