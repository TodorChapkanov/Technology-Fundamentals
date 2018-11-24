namespace _02_CharacterMultiplier
{
    using System;


    class CharacterMultiplier
    {
        public static void Main()
        {
            var splittedInput = Console.ReadLine().Split();
            var firstInput = splittedInput[0];
            var secondInput = splittedInput[1];
            var longestString = "";
            var shortestString = "";
            if (firstInput.Length> secondInput.Length)
            {
                longestString = firstInput;
                shortestString = secondInput;
            }
            else
            {
                longestString = secondInput;
                shortestString = firstInput;
            }
            var result = 0;
            for (int i = 0; i < longestString.Length; i++)
            {
                if (i > shortestString.Length - 1)
                {
                    result += longestString[i];
                }

                else
                {
                    result += longestString[i] * shortestString[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}
