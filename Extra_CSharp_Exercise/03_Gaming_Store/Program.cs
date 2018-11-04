using System;
using System.Collections.Generic;

namespace _03_Gaming_Store
{
    public class Program
    {
        public static void Main()
        {
            string[] games = { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition" };
            decimal[] prices = { 39.99m, 15.99m, 19.99m, 59.99m, 29.99m, 39.99m };

            decimal budget = decimal.Parse(Console.ReadLine());
            string gameName = Console.ReadLine();

            decimal currentBudget = budget;
            decimal price = 0;

            bool gameExistsInArray = false;

            while (gameName != "Game Time")
            {
                for (int i = 0; i < games.Length; i++)
                {
                    if (gameName == games[i])
                    {
                        price = prices[i];
                        if (currentBudget >= price)
                        {
                            Console.WriteLine($"Bought {games[i]}");
                            currentBudget -= prices[i];
                        }
                        else
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        gameExistsInArray = true;
                        if (currentBudget == 0)
                        {
                            Console.WriteLine("Out of money!");
                            return;
                        }

                    }
                    else if (i == games.Length - 1 && !gameExistsInArray)
                    {
                        Console.WriteLine("Not Found");
                    }
                }
                gameName = Console.ReadLine();
            }

            if (currentBudget > 0)
            {
                Console.WriteLine($"Total spent: ${budget - currentBudget:F2}. Remaining: ${currentBudget:F2}");
            }

            Console.Read();
        }
    }
}
