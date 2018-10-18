namespace _02_CommoneElements
{
    using System;
    using System.Linq;

    public class CommoneElements
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().
                Split().
                ToArray();

            var secondArray = Console.ReadLine().
                Split().
                ToArray();

            PrinteIdenticalElement(firstArray, secondArray);
        }


        private static void PrinteIdenticalElement(string[] firstArray, string[] secondArray)
        {
            for (int i = 0; i < secondArray.Length ; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (firstArray[j] == secondArray[i])
                    {
                        Console.Write(secondArray[i]+ " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
