namespace _01_Train
{
    using System;
    using System.Linq;

    public class Train
    {
        public static void Main()
        {
            var wagonsNumber = int.Parse(Console.ReadLine());
            var peopleNumberInWagon = new int[wagonsNumber];

            for (int i = 0; i < peopleNumberInWagon.Length; i++)
            {
                peopleNumberInWagon[i] = int.Parse(Console.ReadLine());
            }

            var sumOfPeople = SumOfPeople(peopleNumberInWagon);
            for (int i = 0; i < peopleNumberInWagon.Length; i++)
            {
                Console.Write(peopleNumberInWagon[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }

        private static int SumOfPeople(int[] peopleNumberInWagon)
        {
            var sum = 0;
            for (int i = 0; i < peopleNumberInWagon.Length; i++)
            {
                sum += peopleNumberInWagon[i];
            }
            return sum;
        }
    }
}
