using System;

namespace _12_Even_Numbers
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                
                var evenNumber = int.Parse(Console.ReadLine());
                
                if (evenNumber % 2 ==0)
                {
                    Console.WriteLine($"The number is: {Math.Abs (evenNumber)}");
                    return;
                }
                Console.WriteLine("Please write an even number.");
            }
        }
    }
}
