namespace _05_WordFilter
{
    using System;
    using System.Linq;


    public class WordFilter
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .Split()
                .Where(x => x.Length % 2 == 0)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
