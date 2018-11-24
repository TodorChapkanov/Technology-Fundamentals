namespace _01_ValidUsername
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;


    public class ValidUsername
    {
        public static void Main()
        {
            var userNames = Console.ReadLine().Split(", ");

            

            foreach (var name in userNames)
            {
              
                if (name.Length >=3 && name.Length<=16)
                {
                    var isValid = true;

                    foreach (var letter in name)
                    {
                        if (char.IsLetterOrDigit(letter)==false && letter != '-' && letter != '_')
                        {
                            isValid = false;
                        }
                    }
                    if (isValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }

        }
    }
}
