namespace _05_Digits_LettersAndOther
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {
       

        public static void Main()
        {
            var input = Console.ReadLine();
            var charArray = input.ToCharArray();
            
                var outputNumbers = String.Join("", input.Where(char.IsDigit));
                var outputLetters = string.Join("", input.Where(char.IsLetter));
            var outpurSymbols = string.Empty;
            foreach (var chars in input)
            {
                if (char.IsPunctuation(chars) || char.IsSymbol(chars))
                {
                    outpurSymbols += chars;
                }
            }
            Console.WriteLine(outputNumbers);
            Console.WriteLine(outputLetters);
            Console.WriteLine(outpurSymbols);
            
        }
    }
}
