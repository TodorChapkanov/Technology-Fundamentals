namespace _03_CharactersinRange
{
    using System;


    public class CharactersinRange
    {
        public static void Main()
        {
            var firsChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());

            PrinteCharsInRange(firsChar, secondChar);
        }

        private static void PrinteCharsInRange(char firsChar, char secondChar)
        {
            var star = Math.Min(firsChar, secondChar) + 1;
            var end = Math.Max(firsChar, secondChar);
            for (char i = (char)star; i < end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
