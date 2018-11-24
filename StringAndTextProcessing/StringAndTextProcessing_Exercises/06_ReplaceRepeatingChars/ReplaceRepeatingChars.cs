namespace _06_ReplaceRepeatingChars
{
    using System;
    using System.Linq;
    using System.Text;


    public class ReplaceRepeatingChars
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            input += "0";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length-1; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] != input[j])
                    {
                        sb.Append(input[i]);
                        i = j - 1;
                        break;
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
