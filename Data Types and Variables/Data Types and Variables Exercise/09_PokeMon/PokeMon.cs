
namespace _09_PokeMon
{
    using System;


    public class PokeMon
    {
        public static void Main()
        {
            var pokeMonPower = int.Parse(Console.ReadLine());
            var distanceToTargets = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());
            int targerCount = 0;

            var halfPower = Math.Floor(pokeMonPower * 0.50);
            while (pokeMonPower >= distanceToTargets)
            {
                
                    pokeMonPower -= distanceToTargets;
                   targerCount++;

                if (pokeMonPower == halfPower && exhaustionFactor != 0)
                {
                    pokeMonPower /=  exhaustionFactor;
                    continue;
                }
                


            }
            Console.WriteLine(pokeMonPower);
            Console.WriteLine(targerCount);

        }
    }
}
