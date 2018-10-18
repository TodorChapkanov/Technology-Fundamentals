namespace _02_VowelsCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class VowelsCount
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine().ToLower();

            CheckAndPrintevowelsLetters(stringInput);
        }

        private static void CheckAndPrintevowelsLetters(string stringInput)
        {
            

            var letters = new List<char>();
            
            foreach (var letter in stringInput)
            {
                letters.Add(letter);
            }
            var count = 0;
            var consonantsLetter = new char[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < letters.Count; i++)
            {
                for (int j = 0; j < consonantsLetter.Length; j++)
                {
                    if (letters[i] == consonantsLetter[j])
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
