namespace _03_ExtractFile
{
    using System;
    using System.Text;


    public class ExtractFile
    {
        public static void Main()
        {
            var directory = Console.ReadLine();
            var indexOfSymbol = directory.LastIndexOf('\\')+1;
            var indexOfDot = directory.LastIndexOf('.')+1;
            var fileLength = indexOfDot - indexOfSymbol-1;
            var extensionLength = directory.Length - indexOfDot;
            var fileName = directory.Substring(indexOfSymbol, fileLength);
            var extension = directory.Substring(indexOfDot, extensionLength);

            Console.WriteLine($"File name: {fileName}");

            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}
