namespace _01_AdvertisementMessege
{
    using System;


    public class AdvertisementMessege
    {
        public static void Main()
        {
            var messegesCount = int.Parse(Console.ReadLine());

            var phrase = new string[]
            {
               "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            var events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            var cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
            Random random = new Random();

            for (int i = 0; i < messegesCount; i++)
            {
                Console.WriteLine($"{phrase[random.Next(0, phrase.Length-1)]} {events[random.Next(0, events.Length-1)]} {authors[random.Next(0, authors.Length-1)]} – {cities[random.Next(0, cities.Length-1)]}.");
            }
        }
    }
}
