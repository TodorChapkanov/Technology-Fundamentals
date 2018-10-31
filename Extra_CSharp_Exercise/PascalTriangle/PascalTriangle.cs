namespace PascalTriangle
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class PascalTriangle
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var curentRow = new List<int>();
            var nextRou = new List<int>();
            var curentNumber = 1;
            if (num ==0)
            {
                return;
            }

           
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    try
                    {
                        curentNumber = curentRow[j] + curentRow[j - 1];
                        nextRou.Add(curentNumber);
                    }
                    catch (Exception)
                    {

                        curentNumber = 1;
                        nextRou.Add(curentNumber);
                    }
                    Console.Write(curentNumber+" ");
                }
                curentRow.Clear();
                foreach (var item in nextRou)
                {
                    curentRow.Add(item);
                }
                nextRou.Clear();
                Console.WriteLine();
                
            }
        }
    }
}
