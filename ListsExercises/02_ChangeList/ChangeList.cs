namespace _02_ChangeList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChangeList
    {
        public static void Main(string[] args)
        {
            var listInput = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToList();

            var newList = new List<int>();

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "end")
                {
                    break;
                }

                if (command[0] == "Delete")
                {
                    newList = DeleteNumbers(listInput,command);
                }
                else if (command[0] == "Insert")
                {
                    newList = InsertNewInteger(listInput, command);
                }
            }
            Console.WriteLine(string.Join(" ", newList));
        }

        private static List<int> InsertNewInteger(List<int> listInput, string[] command)
        {
            var index = int.Parse(command[1]);
            var number = int.Parse(command[2]);
            listInput.Insert(number, index);
            return listInput;
        }

        private static List<int> DeleteNumbers(List<int> listInput, string[] command)
        {
            var number = int.Parse(command[1]);
            listInput.RemoveAll(x => x == number);
            return listInput;
        }
    }
}
