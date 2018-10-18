namespace _04_ArrayRotation
{
    using System;
    using System.Linq;

    public class ArrayRotation
    {
        public static void Main()
        {
            var arrayInput = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();
            ArrayRotateAndPrint(arrayInput);
        }

        private static void ArrayRotateAndPrint(int[] arrayInput)
        {
            var rotation = int.Parse(Console.ReadLine());
            var tempNumber = 0;
            for (int i = 0; i < rotation; i++)
            {
                tempNumber = arrayInput[0];
                for (int j = 0; j < arrayInput.Length-1; j++)
                {
                    arrayInput[j] = arrayInput[j + 1];
                }
                arrayInput[arrayInput.Length - 1] = tempNumber;
            }
            Console.WriteLine(string.Join(' ', arrayInput));
        }
    }
}
