using System;

namespace _11_Multiplication_Table_2._0
{
    public class Program
    {
        public static void Main()
        {
            var numberToMultiplication = int.Parse(Console.ReadLine());
            var multiplicationBy = int.Parse(Console.ReadLine());
            if (multiplicationBy<=10)
            {
                for (int i = multiplicationBy; i <= 10; i++)
                {
                    var result = numberToMultiplication * i;
                    Console.WriteLine($"{numberToMultiplication} X {i} = {result}");
                }
            }
            else
            {
                var result = numberToMultiplication * multiplicationBy;
                Console.WriteLine($"{numberToMultiplication} X {multiplicationBy} = {result} ");
            }

        }
    }
}