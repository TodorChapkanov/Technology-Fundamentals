namespace _08_LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class LettersChangeNumbers
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            
           

            decimal result = 0.00M;
            decimal sum = 0.00M;
            var changedNumbers = new List<double>();
            foreach (var number in input)
            {

                decimal numberForOperation = 0.00M;
                var numerInString = new string(number.Where(x => char.IsNumber(x)).ToArray());
                var curentNumber = decimal.Parse(numerInString);
                if (curentNumber == 0)
                {

                }
                if (char.IsUpper(number[0]))
                {
                   
                   
                        numberForOperation = FindeNumberFromUpperCaseLetter(number[0]);
                        result = curentNumber / numberForOperation;
                    
                    

                }
                if (char.IsLower(number[0]))
                {
                   
                        numberForOperation = FindeNumberFromLowerCaseLetter(number[0]);
                        result = curentNumber * numberForOperation;
                    
                    
                }
                if (char.IsUpper(number[number.Length - 1]))
                {
                        numberForOperation = FindeNumberFromUpperCaseLetter(number[number.Length - 1]);
                        result = result - numberForOperation;

                    
                }
                if (char.IsLower(number[number.Length - 1]))
                {
                        numberForOperation = FindeNumberFromLowerCaseLetter(number[number.Length - 1]);
                        result = result + numberForOperation;
                  
                    
                }

                sum += result;
            }
            Console.WriteLine($"{sum:f2}");

        }
        public static int FindeNumberFromUpperCaseLetter(char letter)
        {
            var numberForOperation = (int)letter - 64;
            return numberForOperation;
        }
        public static int FindeNumberFromLowerCaseLetter(char letter)
        {
            var numberForOperation = (int)letter - 96;
            return numberForOperation;
        }
    }
}
