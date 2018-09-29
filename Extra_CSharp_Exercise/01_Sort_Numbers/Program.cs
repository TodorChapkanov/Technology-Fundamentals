using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Sort_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var listOfNumber = new  List<int>();
            for (int i = 0; i < 3; i++)
            {
                listOfNumber.Add(int.Parse(Console.ReadLine()));
            }
            listOfNumber.Sort();
            listOfNumber.Reverse();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(listOfNumber[i]);
            }
            
        }
    }
}
