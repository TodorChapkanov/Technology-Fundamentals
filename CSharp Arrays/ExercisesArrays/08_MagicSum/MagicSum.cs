namespace _08_MagicSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MagicSum
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            var magicNumber = int.Parse(Console.ReadLine());

            var curentFitsNumber = 0;
            var curentSecondNumber = 0;
            var firstNumber = new List<int>();
            var seconNumber = new List<int>();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                for (int j = i+1; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] + arrayOfNumbers[j] == magicNumber)
                    {
                        curentFitsNumber = arrayOfNumbers[i];
                        curentSecondNumber = arrayOfNumbers[j];
                        if (firstNumber.Exists(x => x == curentFitsNumber) && seconNumber.Exists(x => x == curentSecondNumber)) 
                        {
                            continue;
                        }
                        
                        firstNumber.Add(arrayOfNumbers[i]);
                        seconNumber.Add(arrayOfNumbers[j]);
                        Console.WriteLine(curentFitsNumber + " " + curentSecondNumber);
                    }
                }
                
            }
        }
    }
}
