namespace Einstein_sRiddle
{
    using System;

    public class Einstein_sRiddle
    {
        static string[] houses = { "Red", "Green", "Yellow", "White", "Blue" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PillMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];


        public static void Main()
        {
            Random rand = new Random();
            Shuffle(rand);
            GenerateHints();

            Console.WriteLine("Einstein's riddle");
            Console.WriteLine("The situation:");
            Console.WriteLine("    1.There are 5 houses in five different colors.");
            Console.WriteLine("    2.In each house lives a person with a differen nationality.");
            Console.WriteLine("    3.These five owners drink a certain type of beverage, smoke a certain brand of cigar and keep a certain pet.");
            Console.WriteLine("    4.No owners have the same pet, smoke the same brande of cigar or drink the same beverage.");

            Console.WriteLine($"The question is: Who owns the {pets[0]}?");
            Console.WriteLine("HINTS:");

            for (int i = 1; i <= hints.Length; i++)
            {
                Console.WriteLine($"{i}. {hints[i - 1]}");
            }

            Console.WriteLine("Einstein wrot this riddle this century. He said that 98% of the world could not solve it.");
            Console.WriteLine("To see the solution type solution");

            string solution = Console.ReadLine();
            while (solution.ToLower() != "solution")
            {
                Console.WriteLine("Wrong command! Try again!");
                solution = Console.ReadLine();
            }
            PrintSolution();
        }

        public static void PrintSolution()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"In the {houses[i]} lives the {nationalities[i]}. He drinks {drinks[i]}, smokes {cigarettes[i]} and has {pets[i]} as a pet.");
            }
        }

        public static void GenerateHints()
        {
            hints[0] = $"the {nationalities[2]} lives in the {houses[2]} house";
            hints[1] = $"the {nationalities[4]} keeps {pets[4]} as pets";
            hints[2] = $"the {nationalities[1]} drinks {drinks[1]}";
            hints[3] = $"the {houses[3]} house is on the left of the {houses[4]} house";
            hints[4] = $"the {houses[3]} house's owner drinks {drinks[3]}";
            hints[5] = $"the person who smokes {cigarettes[3]} rears {pets[3]}";
            hints[6] = $"the owner of the {houses[4]} house smokes {cigarettes[4]}";
            hints[7] = $"the man living in the center house drinks {drinks[2]}";
            hints[8] = $"the {nationalities[0]} lives in the first house";
            hints[9] = $"the man who smokes {cigarettes[1]} lives next to the one who keeps {pets[2]}";
            hints[10] = $"the man who keeps {pets[2]} lives next to the man who smokes {cigarettes[3]}";
            hints[11] = $"the owner who smokes {cigarettes[4]} drinks {drinks[4]}";
            hints[12] = $"the {nationalities[0]} smokes {cigarettes[0]}";
            hints[13] = $"the {nationalities[4]} lives next to the {houses[3]} house";
            hints[14] = $"the man who smokes {cigarettes[1]} has a neighbor who drinks {drinks[0]}";
        }

        public static void Shuffle(Random rand)
        {
            for (int i = 0; i < 5; i++)
            {
                int randomHousOne = rand.Next(0, houses.Length);
                int randomHouseTwo = rand.Next(0, houses.Length);
                Swap(randomHousOne, randomHouseTwo, houses);

                int randomPetOne = rand.Next(0, pets.Length);
                int randomPetTwo = rand.Next(0, pets.Length);
                Swap(randomPetOne, randomPetTwo, pets);

                int randomNationalityOne = rand.Next(0, nationalities.Length);
                int randomNationalityTwo = rand.Next(0, nationalities.Length);
                Swap(randomNationalityOne, randomNationalityTwo, nationalities);

                int randomCigaretteOne = rand.Next(0, cigarettes.Length);
                int randomCigaretteTwo = rand.Next(0, cigarettes.Length);
                Swap(randomCigaretteOne, randomCigaretteTwo, cigarettes);

                int randomDrinkOne = rand.Next(0, drinks.Length);
                int randomDrinkTwo = rand.Next(0, drinks.Length);
                Swap(randomDrinkOne, randomDrinkTwo, drinks);
            }
        }
        public static void Swap(int randomOne, int randomTwo, string[] category)
        {
            var temp = category[randomOne];
            category[randomOne] = category[randomTwo];
            category[randomTwo] = temp;
        }
    }
}
