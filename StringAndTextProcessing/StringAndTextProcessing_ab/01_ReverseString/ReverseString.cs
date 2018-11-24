namespace _01_ReverseString
{
    using System;
    using System.Linq;


    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var reversedInput = string.Empty;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput += input[i];
                }
                Console.WriteLine($"{input} = {reversedInput}");
                input = Console.ReadLine();
            }
        }
    }
}
