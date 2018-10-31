namespace _05_SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class SoftUniParking
    {
        public static void Main(string[] args)
        {
            var numberOfCommands = int.Parse(Console.ReadLine());
            var parkingDictionary = new Dictionary<string, string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                

                if (command[0] == "register")
                {
                    var name = command[1];
                    var regPlate = command[2];

                    if (!parkingDictionary.ContainsKey(name))
                    {
                        parkingDictionary.Add(name, regPlate);
                        Console.WriteLine($"{name} registered { regPlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingDictionary[name]}");
                    }

                }
                else
                {
                    var name = command[1];
                    if (parkingDictionary.ContainsKey(name))
                    {
                        parkingDictionary.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }
            foreach (var users in parkingDictionary)
            {
                Console.WriteLine($"{users.Key} => {users.Value}");
            }
        }
    }
}
