namespace _01_CountCharsInString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class CountCharsInString
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split();


            var charsCount = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                foreach (var letter in text[i])
                {
                    if (!charsCount.ContainsKey(letter))
                    {
                        charsCount[letter] = 0;
                    }
                    charsCount[letter]++;
                }
            }
            foreach (var chars in charsCount)
            {
                Console.WriteLine($"{chars.Key} -> {chars.Value}");
            }
        }
    }
}
