namespace Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Messaging
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            var text = Console.ReadLine();

            var listOfChars = new List<char>();

            foreach (var letter in text)
            {
                listOfChars.Add(letter);
            }
            var sum = 0;
            var number = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                number = numbers[i];
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                var index =sum % (listOfChars.Count);
                Console.Write(listOfChars[index]);
                listOfChars.RemoveAt(index);
                sum = 0;
            }
            Console.WriteLine(); ;
        }
    }
}
