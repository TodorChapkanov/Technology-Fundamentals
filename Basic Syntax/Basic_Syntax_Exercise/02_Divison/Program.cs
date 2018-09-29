using System;

namespace _02_Divison
{
    public class Program
    {
        public static void Main()
        {
            var numberToDivide = int.Parse(Console.ReadLine());

            if (numberToDivide % 10 ==0)
            {
                Console.WriteLine("The number is divisible by 10");
                
            }
            else if (numberToDivide % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
                
            }
            else if (numberToDivide % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
                
            }
            else if (numberToDivide % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
                
            }
            else if (numberToDivide % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
                
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
