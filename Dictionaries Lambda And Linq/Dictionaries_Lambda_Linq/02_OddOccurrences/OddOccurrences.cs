namespace _02_OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class OddOccurrences
    {
        public  static void Main()
        {
            var text = Console.ReadLine().ToLower().Split();
            var oddWords = new Dictionary<string, int>();
            foreach (var word in text)
            {
                if (!oddWords.ContainsKey(word))
                {
                    oddWords[word] = 0;
                }
                oddWords[word]++;
            }
            oddWords.Where(x => x.Value % 2 == 1)
                .ToList().
                ForEach(x => Console.Write(x.Key+" "));
            Console.WriteLine(); 
        }
    }
}
