using System;

namespace _10_Multiplication_Table
{
    public class Program
    {
        public static void Main()
        {
            var numberToMultiplication = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var result = numberToMultiplication * i;
                Console.WriteLine($"{numberToMultiplication} X {i} = {result}");
            }
        }
    }
}
