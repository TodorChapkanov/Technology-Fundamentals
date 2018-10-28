namespace _03_HouseParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HouseParty
    {
        public static void Main()
        {
            var numbersOfCommands = int.Parse(Console.ReadLine());
            var listOfGuests = new List<string>();
            for (int i = 0; i < numbersOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                var guest = command[0];
                if (command[2] == "not")
                {
                    
                    if (listOfGuests.Exists(x => x == guest))
                    {
                        listOfGuests.Remove(guest);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }
                }
                else
                {
                    if (!listOfGuests.Exists(x => x == guest))
                    {
                        listOfGuests.Add(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                    }
                }
            }
            foreach (var guest in listOfGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
