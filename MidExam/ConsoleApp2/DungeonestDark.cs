namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ConsoleApp2
    {
        public static void Main()
        {
            int curentHealth = 100;
            int curentCoins = 0;

            var rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < rooms.Length; i++)
            {
                var curentRoom = rooms[i].Split();
                if (curentRoom[0] == "potion")
                {
                    curentHealth += int.Parse(curentRoom[1]);

                    if (curentHealth > 100)
                    {
                        var poition = Math.Abs(curentHealth - 100 - int.Parse(curentRoom[1]));
                        Console.WriteLine($"You healed for {poition} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        curentHealth = 100;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {curentRoom[1]} hp.");
                        Console.WriteLine($"Current health: {curentHealth} hp.");
                        continue;
                    }
                }
                if (curentRoom[0] == "chest")
                {
                    curentCoins += int.Parse(curentRoom[1]);
                    Console.WriteLine($"You found {curentRoom[1]} coins.");
                }
                else
                {
                    curentHealth -= int.Parse(curentRoom[1]);
                    if (curentHealth > 0)
                    {
                        Console.WriteLine($"You slayed {curentRoom[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {curentRoom[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {curentCoins}");
            Console.WriteLine($"Health: {curentHealth}");
        }
    }
}
