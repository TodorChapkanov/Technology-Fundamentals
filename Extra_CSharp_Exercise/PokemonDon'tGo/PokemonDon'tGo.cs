namespace PokemonDon_tGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class Program
    {
        public static void Main()
        {
            var input =Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            long removedNumber = 0;
            long sum = 0;

            while (input.Count !=0)
            {
                var curentIndex = int.Parse(Console.ReadLine());

                if (curentIndex < 0)
                {
                    removedNumber = input[0];
                    input[0] = input[input.Count - 1];
                }
                else if (curentIndex >= input.Count)
                {
                    removedNumber = input[input.Count - 1];
                    input[input.Count - 1] = input[0];
                }
                else
                {
                    removedNumber = input[curentIndex];
                    input.RemoveAt(curentIndex);
                    
                    
                }
                sum += removedNumber;
                for (int i = 0; i < input.Count; i++)
                {

                    if (input[i] <= removedNumber)
                    {
                        input[i] += removedNumber;
                    }
                    else
                    {
                        input[i] -= removedNumber;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
