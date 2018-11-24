namespace _09_RageQuit
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();
            
            StringBuilder sb = new StringBuilder();
            var symbolsCount = 0;
            var startIndex = 0;
            var uniqueLetters = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                StringBuilder curentString = new StringBuilder();
                StringBuilder numberInString = new StringBuilder();

               
               

                if (char.IsDigit(input[i]))
                {
                    numberInString.Append(input[i]);
                    if ( i+1 <= input.Length-1)
                    {
                        if (char.IsDigit(input[i + 1]) )
                        {
                            numberInString.Append(input[i + 1]);
                        }
                        
                    }

                    var repeatCount = int.Parse(numberInString.ToString());
                    for (int r = startIndex; r < i; r++)
                    {
                        
                        curentString.Append(input[r]);
                        if (!uniqueLetters.Contains(input[r]))
                        {
                            uniqueLetters.Add(input[r]);
                        }
                    }
                    
                    for (int j = 0; j < repeatCount; j++)
                    {
                        sb.Append(curentString);
                    }
                    startIndex = i+1;
                }
            }
           
            Console.WriteLine($"Unique symbols used: {uniqueLetters.Count}");
            Console.WriteLine(sb);

        }
    }
}
