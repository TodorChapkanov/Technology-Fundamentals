namespace _04_ListOfProducts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ListOfProducts
    {
        public static void Main()
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            var ProductsList = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                ProductsList.Add(Console.ReadLine());
            }
            ProductsList.Sort();

            for (int i = 0; i < ProductsList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{ProductsList[i]}");
            }
        }
    }
}
