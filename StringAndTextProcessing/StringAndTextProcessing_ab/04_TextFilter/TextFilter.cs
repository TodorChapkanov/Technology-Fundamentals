namespace _04_TextFilter
{
    using System;


    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(", ");

            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                var wordLength = bannedWords[i].Length;
                var wordToReplace = new string('*', wordLength);

                text = text.Replace(bannedWords[i], wordToReplace);
            }
            Console.WriteLine(text);
        }
    }
}

