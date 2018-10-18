namespace _09_PalindromeIntegers
{
    using System;
    using System.Linq;

    public class PalindromeIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var polindromeInteger = BooleanPolindromeInteger(input);
            


            while (input != "END")
            {
                Console.WriteLine(polindromeInteger);
                input = Console.ReadLine();
                polindromeInteger = BooleanPolindromeInteger(input);

                
            }
            
        }

        private static string BooleanPolindromeInteger(string input)
        {
            var count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length-1-i])
                {
                    count++;
                }
                
            }

            if (count == input.Length)
            {
                return "true";
            }
            return "false";
            
        }
    }
}
