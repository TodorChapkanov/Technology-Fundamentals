namespace _04_PrintingTriangle
{
    using System;


    public class PrintingTriangle
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrinteTopSide(number);
            PrinteBottomSide(number);
        }

        private static void PrinteTopSide(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                for (int j  = 1;  j  <= i;  j ++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrinteBottomSide(int number)
        {
            for (int i = number; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
