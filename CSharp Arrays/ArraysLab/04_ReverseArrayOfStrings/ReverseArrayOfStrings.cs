using System;

namespace _04_ReverseArrayOfStrings
{
    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine().Split();
            PrintReverseArray(stringInput);
        }

        public static void PrintReverseArray(string[] stringInput)
        {
            for (int i = stringInput.Length - 1; i >= 0; i--)
            {
                Console.Write(stringInput[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
