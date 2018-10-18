namespace _04_PasswordValidator
{
    using System;


    public class PasswordValidator
    {
        public static void Main()
        {
            var passwordInput = Console.ReadLine().ToLower();
            var passwordLength = PasswordLengthValidation(passwordInput);
            var consistLettersAndDigits = ConsistLettersAndDigitsValidation(passwordInput);
            var consistTwoDigits = ConsistTwoDigitsValidation(passwordInput);

            if (passwordLength == true && consistLettersAndDigits == true && consistTwoDigits == true)
            {
                Console.WriteLine("Password is valid");
                return;
                }
            

        }

        private static bool PasswordLengthValidation(string passwordInput)
        {
            var count = 0;
            foreach (var item in passwordInput)
            {
                count++;
            }
            if (6 <= count && count <= 10)
            {
                return true;
            }
            Console.WriteLine("Password must be between 6 and 10 characters");
            return false;
        }

        private static bool ConsistLettersAndDigitsValidation(string passwordInput)
        {
            var numberAndDigits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var count = 0;
            var PasswordInCHarList = passwordInput.ToCharArray();
            foreach (var symbol in passwordInput)
            {
                for (int i = 0; i < numberAndDigits.Length; i++)
                {
                    if (symbol == numberAndDigits[i])
                    {
                        count++;
                    }

                }

            }
            if (count == PasswordInCHarList.Length)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return false;
            }

        }

        private static bool ConsistTwoDigitsValidation(string passwordInput)
        {
            var passwordArray = passwordInput.ToCharArray();
            var arrayOfNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var count = 0;

            for (int i = 0; i < passwordArray.Length; i++)
            {
                for (int j = 0; j < arrayOfNumbers.Length; j++)
                {
                    if (passwordArray[i] == arrayOfNumbers[j])
                    {
                        count++;
                    }

                }
            }

            if (count >= 2)
            {
                return true;
            }

            else
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
        }
    }
}