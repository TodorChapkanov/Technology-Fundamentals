namespace _01_BakingMastercass
{
    using System;


    public class BakingMastercass
    {
        public static void Main()
        {
            
            var budget = double.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var pricePerFlour = double.Parse(Console.ReadLine());
            var pricePerEgg = double.Parse(Console.ReadLine());
            var pricePerApron = double.Parse(Console.ReadLine());

            var eggsForStudents = students*( pricePerEgg * 10);
            var apronForStudents = pricePerApron*Math.Ceiling(students+(students*0.20));
            var flourForStudents = (students - (students / 5)) * pricePerFlour;
            var moneySpend = eggsForStudents + apronForStudents + flourForStudents;

            if (moneySpend <= budget)
            {
                Console.WriteLine($"Items purchased for { moneySpend:f2}$.");
            }
            else
            {
                var moneyNeed = moneySpend - budget;
                Console.WriteLine($"{moneyNeed:f2}$ more needed.");
            }
        }
    }
}
