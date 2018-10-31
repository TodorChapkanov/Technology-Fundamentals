namespace _02_AMinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class AMinerTask
    {
        public static void Main()
        {
            var quantityOfResource = new Dictionary<string, int>();
            while (true)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                var quantity = int.Parse(Console.ReadLine());
                if (!quantityOfResource.ContainsKey(resource))
                {
                    quantityOfResource[resource] = 0;
                }
                quantityOfResource[resource] += quantity;
            }
            foreach (var resource in quantityOfResource)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
