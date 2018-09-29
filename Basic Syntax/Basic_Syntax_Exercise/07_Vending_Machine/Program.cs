using System;

namespace _07_Vending_Machine
{
    public class Program
    {
        public static void Main()
        {
            var totalInsertedMoney = 0.00;
            while (true)
            {
                var insertedMoney = Console.ReadLine().ToLower().Trim();
                if (insertedMoney == "start")
                {
                    break;
                }
                if (insertedMoney == "0.1" || insertedMoney == "0.2" || insertedMoney =="0.5" || insertedMoney == "1" || insertedMoney == "2")
                {
                    totalInsertedMoney += double.Parse(insertedMoney);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedMoney}");
                }
            }
            while (true)
            {
                var purchasedItems = Console.ReadLine().ToLower().Trim();
                var priceForItem = 0.00;
                if (purchasedItems == "end")
                {
                    Console.WriteLine($"Change: {totalInsertedMoney:f2}");
                    break;
                }
                switch (purchasedItems)
                {
                    case "nuts":
                        priceForItem = 2.00;
                        break;
                    case "water":
                        priceForItem = 0.7;
                        break;
                    case "crisps":
                        priceForItem = 1.5;
                        break;
                    case "soda":
                        priceForItem = 0.8;
                        break;
                    case "coke":
                        priceForItem = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (totalInsertedMoney >= priceForItem && purchasedItems == "nuts" || purchasedItems == "water" || purchasedItems == "crisps" || purchasedItems == "soda" || purchasedItems == "coke")
                {
                    totalInsertedMoney -= priceForItem;
                    Console.WriteLine($"Purchased {purchasedItems}");
                }
                else if (priceForItem > totalInsertedMoney)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
        }
    }
}
