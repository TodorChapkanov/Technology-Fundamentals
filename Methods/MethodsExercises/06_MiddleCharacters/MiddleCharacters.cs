namespace _06_MiddleCharacters
{
    using System;


    public class MiddleCharacters
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine().ToCharArray();
            var middle = GetMiddle(stringInput);

            if (stringInput.Length % 2 ==0)
            {
                Console.WriteLine($"{stringInput[middle-1]}{stringInput[middle]}");
            }
            else
            {
                Console.WriteLine(stringInput[middle]);
            }
        }

        private static int GetMiddle(char[] stringInput)
        {
            var middle = stringInput.Length / 2;
            return middle;
        }
    }
}
