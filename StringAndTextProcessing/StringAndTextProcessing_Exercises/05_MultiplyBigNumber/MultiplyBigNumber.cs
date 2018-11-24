namespace _06_MultiplyBigNumber
{
    using System;
    using System.Text;
    using System.Linq;


    public class MultiplyBigNumber
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var multiplyNumber = long.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            long numberLeft = 0;
            if (multiplyNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (input.Length == 0)
            {
                if (int.Parse(input) == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                var curentNumber = int.Parse(input[i].ToString());

                var result = curentNumber * multiplyNumber;
                result += numberLeft;



                var digitToAdd = result % 10;
                numberLeft = result / 10;

                sb.Append(digitToAdd);
            }
            if (numberLeft != 0)
            {
                sb.Append(numberLeft.ToString());
            }



            var stringOutput = new string(sb.ToString().Reverse().ToArray());
            for (int i = 0; i < stringOutput.Length / 2; i++)
            {
                if (stringOutput[0] == '0')
                {
                    stringOutput = stringOutput.Remove(0, 1);
                    i = -1;
                }
            }

            Console.WriteLine(stringOutput);
        }
    }
}