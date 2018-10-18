namespace _05_Orders
{
    using System;


    public class Orders
    {
        public static void Main()
        {
            var product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            CalculateAndPrintTotalPrice(product, quantity);
        }

        private static void CalculateAndPrintTotalPrice(string product, int quantity)
        {
            var price = 0.00;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                    
            }
            var result = price * quantity;
            Console.WriteLine($"{result:f2}");
        }
    }
}
