using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Login
{
    public class Program
    {
        public static void Main()
        {
            var userName = Console.ReadLine();

            var passwordInput = Console.ReadLine().ToString();
            var password = new string(passwordInput.Reverse().ToArray());
            var incorrectCounter = 1;
            while (userName != password)
            {
                incorrectCounter += 1;
                Console.WriteLine("Incorrect password. Try again.");
                passwordInput = Console.ReadLine();
                password = new string (passwordInput.Reverse().ToArray());
                
                
                if (incorrectCounter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }

            }
            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
