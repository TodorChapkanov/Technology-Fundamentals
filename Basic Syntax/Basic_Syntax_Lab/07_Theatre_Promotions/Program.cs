using System;

namespace _07_Theatre_Promotions
{
    public class Program
    {
        public static void Main()
        {
            var typeOfDay = Console.ReadLine();
            var ageOfPerson = int.Parse(Console.ReadLine());
            var priceForTicket = 0;

            if (typeOfDay == "Weekday")
            {
                if (0<=ageOfPerson && ageOfPerson <=18)
                {
                    priceForTicket = 12;
                }
                else if (18<ageOfPerson && ageOfPerson <=64)
                {
                    priceForTicket = 18;
                }
                else if (64 < ageOfPerson && ageOfPerson <= 122)
                {
                    priceForTicket = 12;
                }
            }
            if (typeOfDay == "Weekend")
            {
                if (0 <= ageOfPerson && ageOfPerson <= 18)
                {
                    priceForTicket = 15;
                }
                else if (18 < ageOfPerson && ageOfPerson <= 64)
                {
                    priceForTicket = 20;
                }
                else if (64 < ageOfPerson && ageOfPerson <= 122)
                {
                    priceForTicket = 15;
                }
            }
            if (typeOfDay == "Holiday")
            {
                if (0 <= ageOfPerson && ageOfPerson <= 18)
                {
                    priceForTicket = 5;
                }
                else if (18 < ageOfPerson && ageOfPerson <= 64)
                {
                    priceForTicket = 12;
                }
                else if (64 < ageOfPerson && ageOfPerson <= 122)
                {
                    priceForTicket = 10;
                }
            }
            if (priceForTicket !=0)
            {
                Console.WriteLine($"{priceForTicket}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
