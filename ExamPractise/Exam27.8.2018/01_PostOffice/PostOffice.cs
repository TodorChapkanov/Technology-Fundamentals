namespace _01_PostOffice
{
    using System;
    using System.Text.RegularExpressions;

    public class PostOffice
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split("|");

            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string firstPattern = @"[#$%*&](?<letters>[A-Z]+)[#$%*&]";
            Match firstMatch = Regex.Match(firstPart, firstPattern);
            string capitals = firstMatch.Groups["letters"].Value;

            for (int index = 0; index < capitals.Length; index++)
            {
                char startLetter = capitals[index];
                int ASCIIcode = startLetter;

                string secondPattern = $@"{ASCIIcode}:(?<length>[0-9][0-9])";
                Match secondMatch = Regex.Match(secondPart, secondPattern);
                int length = int.Parse(secondMatch.Groups["length"].Value);

                string thirdPattern = $@"\b{startLetter}[^\s]{{{length}}}\b";
                Match thirdMatch = Regex.Match(thirdPart, thirdPattern);
                string word = thirdMatch.ToString();

                Console.WriteLine(word);
            }
        }
    }
}
