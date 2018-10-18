namespace _07_NxNMatrix
{
    using System;


    public class NxNMatrix
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrinteMatrix(number);
        }

        private static void PrinteMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(number);

                for (int j = 0; j < number-1; j++)
                {
                    Console.Write(" " + number);
                }
                Console.WriteLine();
            }
        }
    }
}
