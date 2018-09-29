using System;

namespace _10_Rage_Expenses
{
    public class Program
    {
        public static void Main()
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = lostGames / 6;
            int trashedDisplay = lostGames / 12;
            double costsForEquipment = (headsetPrice * trashedHeadset) + (mousePrice * trashedMouse) + (keyboardPrice * trashedKeyboard) + (displayPrice * trashedDisplay);
            Console.WriteLine($"Rage expenses: {costsForEquipment:f2} lv.");
        }
    }
}
