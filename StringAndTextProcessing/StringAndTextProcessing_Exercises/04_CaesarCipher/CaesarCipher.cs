namespace _04_CaesarCipher
{
    using System;
    using System.Text;


    public class CaesarCipher
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            StringBuilder cipher = new StringBuilder();
            foreach (var letter in input)
            {
                char curentChar = (char)(letter + 3);
                cipher.Append(curentChar);
            }
            Console.WriteLine(cipher);
        }
        
       
    }
}
