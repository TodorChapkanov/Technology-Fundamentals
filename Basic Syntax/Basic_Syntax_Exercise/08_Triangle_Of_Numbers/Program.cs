using System;

namespace _08_Triangle_Of_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numberInput = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberInput; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
