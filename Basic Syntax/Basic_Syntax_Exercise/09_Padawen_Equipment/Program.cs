using System;

namespace _09_Padawen_Equipment
{
    public class Program
    {
        public static void Main()
        {
            var moneyToSpend = double.Parse(Console.ReadLine());
            var numberOfStudents = int.Parse(Console.ReadLine());
            var priceOfLightsaber = double.Parse(Console.ReadLine());
            var priceOfRobe = double.Parse(Console.ReadLine());
            var priceOfBelt = double.Parse(Console.ReadLine());

            var extraLightsabres = Math.Ceiling(numberOfStudents + (numberOfStudents * 0.1));
            var totalBelts = numberOfStudents - (numberOfStudents / 6);

            var spendetMoney = (extraLightsabres * priceOfLightsaber) + (numberOfStudents * priceOfRobe) + (totalBelts * priceOfBelt);
            if (moneyToSpend >= spendetMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {spendetMoney:f2}lv.");
            }
            else
            {
                var difference = Math.Abs(moneyToSpend - spendetMoney);
                Console.WriteLine($"Ivan Cho will need {difference:f2}lv more.");
            }
        }
    }
}
