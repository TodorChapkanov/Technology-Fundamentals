

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ConsoleApp1
    {
        public static void Main()
        {
            var partySize = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var spend = 0;
            var curentSum = 0;
            var food = 0;
            var totalCoyns =0;

            for (int i = 1; i <= days; i++)
            {
                
                totalCoyns +=50;

                if (i % 10 == 0)
                {
                    partySize -= 2;
                    
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                food = food + (partySize * 2);
                if (i % 3 == 0)
                {
                    curentSum += partySize * 3;
                }
                if (i % 5 == 0)
                {
                    totalCoyns = totalCoyns + (partySize * 20);
                    if (i % 3 == 0)
                    {
                        curentSum += partySize * 2;
                    }
                }
                
            }
            spend = Math.Abs( totalCoyns - (curentSum + food));
            var coynsePerPurcen = spend / partySize;

            Console.WriteLine($"{partySize} companions received {coynsePerPurcen} coins each.");

        }
    }
}
