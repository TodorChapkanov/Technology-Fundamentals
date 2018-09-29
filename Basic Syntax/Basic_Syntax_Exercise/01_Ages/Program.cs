using System;

namespace _01_Ages
{
    public class Program
    {
        public static void Main()
        {
            var ageInput = int.Parse(Console.ReadLine());

            if (ageInput >=66)
            {
                Console.WriteLine("elder");
                return;
            }
            else if (ageInput >= 20)
            {
                Console.WriteLine("adult");
                
            }
           else  if (ageInput >= 14)
            {
                Console.WriteLine("teenager");
                
            }
            else if (ageInput >= 3)
            {
                Console.WriteLine("child");
                
            }
            else if (ageInput >= 0)
            {
                Console.WriteLine("baby");
                
            }
        }
    }
}
