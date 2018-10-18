namespace _05_TopIntegers
{
    using System;
    using System.Linq;

    public class TopIntegers
    {
        public static void Main()
        {
            var arrayInput = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            FindAndPrintTopIntegers(arrayInput);
        }

        private static void FindAndPrintTopIntegers(int[] arrayInput)
        {
            
            for (int i = 0; i < arrayInput.Length; i++)
            {
                bool isBigger = true;
                for (int j = i+1; j < arrayInput.Length; j++)
                {
                    if (arrayInput[i] <= arrayInput[j])
                    {
                        isBigger = false;
                    }
                }
                if (isBigger)
                {
                    Console.Write(arrayInput[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
