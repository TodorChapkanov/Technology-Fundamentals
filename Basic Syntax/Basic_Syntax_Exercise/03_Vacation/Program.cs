using System;

namespace _03_Vacation
{
    public class Program
    {
        public static void Main()
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var typeOfGroup = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            double priceBeforDiscount = TotalPriceForGroup(numberOfPeople, typeOfGroup, dayOfWeek);
            double totalPrice = PriceAfterDiscount(priceBeforDiscount, numberOfPeople, typeOfGroup);

            Console.WriteLine($"Total price: {totalPrice:f2}");



        }


        public static double TotalPriceForGroup(int numberOfPeople, string typeOfGroup, string dayOfWeek)
        {
            double totalPrice = 0;
            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    totalPrice = numberOfPeople * 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    totalPrice = numberOfPeople * 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    totalPrice = numberOfPeople * 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    totalPrice = numberOfPeople * 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    totalPrice = numberOfPeople * 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    totalPrice = numberOfPeople * 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    totalPrice = numberOfPeople * 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    totalPrice = numberOfPeople * 16.00;
                }
                else if (typeOfGroup == "Regular")
                {
                    totalPrice = numberOfPeople * 22.50;
                }
            }
            return totalPrice;
        }


        public static double PriceAfterDiscount (double totalPrice, int  numberOfPeople, string typeOfGroup)
        {
            double priceAfterDiscount = 0;
            if (typeOfGroup == "Students" && numberOfPeople >= 30)
            {
                priceAfterDiscount = totalPrice - (totalPrice * 0.15);
            }
            else if (typeOfGroup == "Business" && numberOfPeople >=100)
            {
                priceAfterDiscount = totalPrice- (totalPrice / numberOfPeople * 10);
            }
            else if (typeOfGroup == "Regular" && 10<= numberOfPeople && numberOfPeople<=20 )
            {
                priceAfterDiscount = totalPrice - (totalPrice * 0.05);
            }
            else
            {
                priceAfterDiscount = totalPrice;
            }
            return priceAfterDiscount;
        }
    }
}
