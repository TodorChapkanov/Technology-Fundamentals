namespace _02_RandomizeWords
{
    using System;


    public class RandomizeWords
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine().Split();

            var randomIndex = new Random();

            for (int i = 0; i < stringInput.Length; i++)
            {
                var curentIndex = stringInput[i];
                var nextRandomIndex = randomIndex.Next(0, stringInput.Length);
                stringInput[i] = stringInput[nextRandomIndex];
                stringInput[nextRandomIndex] = curentIndex;
            }
            foreach (var word in stringInput)
            {
                Console.WriteLine(word);
            }
        }
    }
}

