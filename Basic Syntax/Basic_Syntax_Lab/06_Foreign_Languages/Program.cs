using System;

namespace _06_Foreign_Languages
{
    public class Program
    {
        public static void Main()
        {
            var nameOfCountry = Console.ReadLine();
            switch (nameOfCountry)
            {
                case "USA":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
