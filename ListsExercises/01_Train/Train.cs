namespace _01_Train
{
    using System;
    using System.Linq;

    public class Train
    {
        public static void Main()
        {
            var wagons = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();
            var maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                var passengers = Console.ReadLine().Split();
                if (passengers[0] == "end")
                {
                    break;
                }
                if (passengers[0] == "Add")
                {
                    var wagonWithPeople = int.Parse(passengers[1]);
                    wagons.Add(wagonWithPeople);
                }
                else
                {
                    var peoplesToAdd = int.Parse(passengers[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + peoplesToAdd <=maxCapacity)
                        {
                            wagons[i] += peoplesToAdd;
                            break;
                        }
                    }
                }
                    
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
