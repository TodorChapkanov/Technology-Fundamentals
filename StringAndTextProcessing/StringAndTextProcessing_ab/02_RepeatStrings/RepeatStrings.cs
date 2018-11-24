namespace _02_RepeatStrings
{
    using System;
    using System.Text;


    public class RepeatStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            foreach (var word in input)
            {
                var count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    sb.Append(word);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
