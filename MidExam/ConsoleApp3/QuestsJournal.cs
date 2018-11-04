namespace ConsoleApp3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ConsoleApp3
    {
        public static void Main()
        {
            var journal = Console.ReadLine().Split(',',StringSplitOptions.RemoveEmptyEntries).ToList();
            var newJournal = new List<string>();
            foreach (var item in journal)
            {
                newJournal.Add(item.Trim());
            }
            var command = new List<string>();
            while (true)
            {
                command = Console.ReadLine().Split(new char[] { '-', ':' },StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0].Trim() == "Retire!")
                {
                    break;
                }
                if (command[0].Trim() == "Complete")
                {
                    if (newJournal.Contains(command[1].Trim()))
                    {
                        newJournal.Remove(command[1].Trim());
                    }
                }
                if (command[0].Trim() == "Start" )
                {
                    if (!newJournal.Contains(command[1].Trim()))
                    {
                        newJournal.Add(command[1].Trim());
                    }
                }
                if (command[0].Trim()  == "Side Quest")
                {
                    if (newJournal.Contains(command[1].Trim()) && !newJournal.Contains(command[2].Trim()))
                    {
                        newJournal.Insert(newJournal.IndexOf(command[1].Trim())+1, command[2].Trim());
                    }
                }
                if (command[0].Trim() == "Renew")
                {
                    if (newJournal.Contains(command[1].Trim()))
                    {
                        newJournal.Remove(command[1].Trim());
                        newJournal.Add(command[1].Trim());
                    }
                    
                }
            }
            Console.WriteLine(string.Join(", ", newJournal));
        }
    }
}
