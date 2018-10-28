namespace _05_ListManipulationBasics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListManipulationBasics
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            while (true)
            {
                var commands = Console.ReadLine();
                if (commands == "end")
                {
                    break;
                }
                var command = commands.Split();

                switch (command[0])
                {
                    case "Add":
                        var numberToAdd = int.Parse(command[1]);
                        numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        var numberToRemove = int.Parse(command[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        var indexToRemove = int.Parse(command[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        var numberToInsert = int.Parse(command[1]);
                        var index = int.Parse(command[2]);
                        numbers.Insert(index, numberToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
