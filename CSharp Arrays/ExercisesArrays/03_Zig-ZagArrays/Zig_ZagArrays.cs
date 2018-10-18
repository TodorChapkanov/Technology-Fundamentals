namespace _03_Zig_ZagArrays
{
    using System;
    using System.Linq;

    public class Zig_ZagArrays
    {
        public static void Main()
        {
            var numberOfArrays = int.Parse(Console.ReadLine());

            
            var firstArray = new int[numberOfArrays];
            var secondArray = new int[numberOfArrays];
            var firstArrayCounter = 0;
            var secondArrayCounter = 1;
            for (int i = 0; i < numberOfArrays; i++)
            {
                
                
                   var  curentArray =Console.ReadLine().
                    Split().
                    Select(int.Parse).
                    ToArray();

                firstArray[i] = curentArray[firstArrayCounter];

                if (firstArrayCounter == 0)
                {
                    firstArrayCounter += 1;
                }
                else 
                {
                    firstArrayCounter -= 1;
                }

                secondArray[i] = curentArray[secondArrayCounter];
                if (secondArrayCounter== 0)
                {
                    secondArrayCounter += 1;
                }
                else
                {
                    secondArrayCounter -= 1;
                }
            }
            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}
