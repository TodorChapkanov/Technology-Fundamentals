namespace _10_RepeatString
{
    using System;


    public class RepeatString
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine();
            var repeatCount = int.Parse(Console.ReadLine());

            var result = ConcatenateString(stringInput, repeatCount);
            Console.WriteLine(result);
        }

        private static string ConcatenateString(string stringInput, int repeatCount)
        {
            if (repeatCount == 1)
            {
                return stringInput;
            }
            var concatenateString = string.Empty;
            for (int i = 0; i < repeatCount; i++)
            {
                concatenateString = concatenateString + stringInput;
            }
            return concatenateString;
        }
    }
}
