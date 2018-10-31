namespace EncryptSortAndPrintArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class EncryptSortAndPrintArray
    {
        public static void Main()
        {
            var numberOfNames = int.Parse(Console.ReadLine());
            
            var sumOfLetters = new List<double>();
            var vowels = new Char[] { 'A','a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
            for (int i = 0; i < numberOfNames; i++)
            {
                var curentSum = 0.0;
                var name = Console.ReadLine().ToCharArray();

                foreach (char  chars in name)
                {
                    bool isTrue = false;
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (chars == vowels[i])
                        {
                            curentSum = curentSum + chars * name.Length;
                            isTrue = true;
                            continue;
                        }
                        
                        
                    }
                    if (isTrue)
                    {
                        curentSum = curentSum + chars / name.Length;
                    }
                    
                }
                sumOfLetters.Add(curentSum);

            }
            foreach (var number in sumOfLetters.OrderBy(n => n))
            {
                Console.WriteLine(number);
            }
        }
    }
}
