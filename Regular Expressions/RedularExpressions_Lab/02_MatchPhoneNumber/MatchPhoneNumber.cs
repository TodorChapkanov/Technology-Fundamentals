namespace _02_MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;


    public class MatchPhoneNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";

            MatchCollection numbers = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join(", ",numbers));

        }
    }
}

