namespace _08_GreaterOfTwoValues
{
    using System;


    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            var typeData = Console.ReadLine();

            switch (typeData)

            {
                case "int":
                    var firstNumber = int.Parse(Console.ReadLine());
                    var secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(GreaterInt(firstNumber, secondNumber));
                    break;
                case "char":
                    var firstChar = char.Parse(Console.ReadLine());
                    var secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GreaterChar(firstChar, secondChar));
                    break;
                case "string":
                    var firstString = Console.ReadLine();
                    var secondString = Console.ReadLine();
                    Console.WriteLine(GreaterString(firstString, secondString));
                    break;


            }
        }

        

        private static int GreaterInt(int firstNumber, int secondNumber)
        {
            var result = Math.Max(firstNumber, secondNumber);
            return result;
        }

        private static char GreaterChar(char firstChar, char secondChar)
        {
            var result = (char)Math.Max(firstChar, secondChar);
            return result;
        }

        private static string GreaterString(string firstString, string secondString)
        {
            int result = firstString.CompareTo(secondString);

            if (result > 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
