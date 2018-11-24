namespace _03_Substring
{
    using System;
    using System.Text;


    public class Substring
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower();

            var stringInput = Console.ReadLine();

            var wordLength = words.Length;
            var newString = string.Empty;
            while (true)
            {
                var index = stringInput.IndexOf(words);
                if (index == -1)
                {
                    break;
                }

                 stringInput = stringInput.ToLower().Remove(index, wordLength);
            }
            Console.WriteLine(stringInput);
        }
    }
}
