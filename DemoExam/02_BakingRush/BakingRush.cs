namespace _02_BakingRush
{
    using System;
    using System.Collections.Generic;


    public class BakingRush
    {
        public static void Main()
        {
            var commands = Console.ReadLine().
                Split('|');
            var energy = 100;
            var coins = 100;
            for (int i = 0; i < commands.Length; i++)
            {
                var command = commands[i].Split('-');
                var number = int.Parse(command[1]);
                if (command[0]=="rest")
                {
                    if (energy == 100)
                    {
                        Console.WriteLine("You gained 0 energy.");
                    }
                    else
                    {
                        energy += number;
                        Console.WriteLine($"You gained {number} energy.");
                    }
                    Console.WriteLine($"Current energy: {energy}.");
                }
                else if (command[0] == "order")
                {
                    if (energy-30 >= 0)
                    {
                        energy -= 30;
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        Console.WriteLine("You had to rest!");
                        energy += 50;
                    }
                    
                    
                }
                else
                {
                    if (coins-number >0)
                    {
                        Console.WriteLine($"You bought {command[0]}.");
                        coins -= number;
                    }
                    else
                    {
                        Console.WriteLine($"Closed! Cannot afford {command[0]}.");
                        return;
                    }
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
