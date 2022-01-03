using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        private static readonly string CurrentDir = Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
        private static readonly string Path = (CurrentDir + "\\lear.txt");
        static void Main(string[] args)
        {

            Console.WriteLine("Lines = {0}", Counter.CountLines(Path));
            Console.WriteLine("Words = {0}", Counter.CountWords(Path));
            Console.WriteLine("Chars = {0}", Counter.CountChars(Path));
            Console.ReadKey();
        }
    }
}
