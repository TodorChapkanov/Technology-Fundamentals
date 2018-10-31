namespace _03_WordSynonyms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class WordSynonyms
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var synonyms = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                words[word].Add(synonyms);
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
