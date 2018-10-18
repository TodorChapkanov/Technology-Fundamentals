namespace _08_CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            var arrayOfNumbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            PrintCondenseArray(arrayOfNumbers);
        }

        private static void PrintCondenseArray(int[] arrayOfNumbers)
        {
            if (arrayOfNumbers.Length==1)
            {
                Console.WriteLine(arrayOfNumbers[0]);
                return;
            }

            while (true)
            {
                var condenseArray = new int[arrayOfNumbers.Length - 1];
                for (int i = 0; i < arrayOfNumbers.Length-1; i++)
                {
                    condenseArray[i] = arrayOfNumbers[i] + arrayOfNumbers[i + 1];
                }
                    

                arrayOfNumbers = condenseArray;
                if (arrayOfNumbers.Length == 1)
                {
                    break;
                }
            }
            Console.WriteLine(arrayOfNumbers[0]);
        }
    }
}
