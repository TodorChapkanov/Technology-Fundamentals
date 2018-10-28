namespace _01_RemoveNegativesAndRevers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().
                Split().
                Select(int.Parse).
                Where(n => n >= 0).
                ToList();
            numbers.Reverse();
            if (numbers.Count >0 )
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
