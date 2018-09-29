using System;
using System.Collections.Generic;

namespace _02_English_Name_Of_The_Last_Digit
{
    public class Program
    {
        public static void Main()
        {
            var dictionariOfEnglishNames = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
            };

            var numbreInput = int.Parse(Console.ReadLine());

            var lastDigit = numbreInput % 10;
            Console.WriteLine(dictionariOfEnglishNames[lastDigit]);
        }
    }
}
