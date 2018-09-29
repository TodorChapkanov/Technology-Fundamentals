using System;

namespace _05_Month_Printer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var monthInNumber = int.Parse(Console.ReadLine());
            var monthInWords = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            if (monthInNumber<=monthInWords.Length && monthInNumber>0)
            {
                Console.WriteLine($"{monthInWords[monthInNumber - 1]}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
