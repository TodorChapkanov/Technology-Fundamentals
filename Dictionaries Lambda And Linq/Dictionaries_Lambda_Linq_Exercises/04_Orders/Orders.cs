namespace _04_Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Orders
    {
        public static void Main()
        {
            var namePriceDictionary = new Dictionary<string, double>();
            var nameQuatityDictionary = new Dictionary<string, int>();
            var name = "";
            var quantity = 0;
            var price = 0.0;
            while (true)
            {
                var products = Console.ReadLine().Split();

                if (products[0] == "buy")
                {
                    break;
                }

                name = products[0];
                price = double.Parse(products[1]);
                quantity = int.Parse(products[2]);
                if (!namePriceDictionary.ContainsKey(name))
                {
                    namePriceDictionary.Add(name, price);
                    nameQuatityDictionary.Add(name, quantity);
                }
                else
                {
                    nameQuatityDictionary[name] += quantity;
                    if (namePriceDictionary[name] != price)
                    {
                        namePriceDictionary[name] = price;
                    }
                }
               
            }
            foreach (var item in namePriceDictionary)
            {
                var result = namePriceDictionary[item.Key] * nameQuatityDictionary[item.Key];

                Console.WriteLine($"{item.Key} -> {result:f2}");
            }
        }
    }
}
