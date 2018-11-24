namespace StoreBoxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item ItemAsObject { get; set; }
        public int Quantity { get; set; }
        public decimal PriceForSingleBox { get; set; }

        public Box(string[] boxInfo)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           

            string input = Console.ReadLine();
            List<Box> result = new List<Box>();
            while (input != "end")
            {
                string[] data = input.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Box box = new Box(data)
                {
                    SerialNumber = serialNumber,
                    ItemAsObject = new Item(itemName, itemPrice),
                    Quantity = itemQuantity,
                    PriceForSingleBox = itemQuantity * itemPrice
                };

                result.Add(box);

                input = Console.ReadLine();
            }

            foreach (Box box in result.OrderByDescending(x => x.PriceForSingleBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.ItemAsObject.Name} - ${box.ItemAsObject.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForSingleBox:f2}");
            }
        }
    }
}
