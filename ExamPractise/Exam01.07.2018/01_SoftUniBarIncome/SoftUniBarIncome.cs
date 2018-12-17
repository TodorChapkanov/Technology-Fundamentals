namespace _01_SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;

    public class SoftUniBarIncome
    {
        public static void Main()
        {
            var totalIncome = 0.00;
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
               
                var customerPattern = new Regex(@"(?<=\%)(?<customer>[A-Z][a-z]*)(?=\%)");
                var cusomer = customerPattern.Match(input);

                var productPattern = new Regex(@"(?<=\<)(?<product>\w+)(?=\>)");
                var product = productPattern.Match(input);

                var quantityPattern = new Regex(@"(?<=\|)(?<quantity>\d+)(?=\|)");
                var quantity = quantityPattern.Match(input);

                var pricePattern = new Regex(@"(?<price>[0-9]+|[0-9]+[.][0-9]+)(?=\$)");
                var price = pricePattern.Match(input);

               
                if (cusomer.Success && product.Success && quantity.Success && price.Success)
                {
                    double totalPrice = double.Parse(quantity.ToString()) * double.Parse(price.ToString());
                    totalIncome += totalPrice;
                    Console.WriteLine($"{cusomer}: {product} - {totalPrice:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
