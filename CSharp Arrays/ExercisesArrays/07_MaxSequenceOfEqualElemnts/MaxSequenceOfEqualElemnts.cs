namespace _07_MaxSequenceOfEqualElemnts
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElemnts
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            var count = 0;
            var curentLength = 0;
            var curentIndex = 0;

            if (arrayOfNumbers.Length == 1)
            {
                Console.WriteLine(arrayOfNumbers[0]);
                return;
            }

            for (int i = 0; i <  arrayOfNumbers.Length-1; i++)
            {
                count = 0;
                for (int j = i; j < arrayOfNumbers.Length; j++)
                {
                    if (arrayOfNumbers[i] == arrayOfNumbers[j])
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    if (curentLength < count)
                    {
                        curentLength = count;
                        curentIndex = j;
                        
                    }
                } 
            }
            for (int i =curentIndex-curentLength+1; i <= curentIndex; i++)
            {
                Console.Write(arrayOfNumbers[i] +" ");
            }
            Console.WriteLine();
        }
    }
}
