using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        private static int _counter;
        private const string Path = @"C:\Users\9er0j\Desktop\Programming\Codelex\C#\Lekcijas\c-sharp-syllabus-KirillTopchy\csharp-basics\exercises\Collections\WordCount\lear.txt";

        static void Main(string[] args)
        {
            CountLines();
            CountWords();
            CountChars();
            Console.ReadKey();
        }

        private static void CountLines()
        {
            _counter = 0;
            foreach (var line in System.IO.File.ReadLines(Path))
            {
                _counter++;
            }
            Console.WriteLine("Lines = {0}", _counter);
        }

        private static void CountWords()
        {
            _counter = 0;
            foreach (var word in System.IO.File.ReadLines(Path))
            {
                // replace multiple spaces with single one and split string by space.
                var splited = Regex.Replace(word, @"\s+", " ").Split(' ');
                for (int i = 0; i < splited.Length; i++)
                {
                    _counter++;
                }
            }
            Console.WriteLine("Words = {0}", _counter);
        }

        private static void CountChars()
        {
            _counter = 0;
            foreach (var c in System.IO.File.ReadAllText(Path).Where(char.IsLetterOrDigit))
            {
                _counter++;
            }
            Console.WriteLine("Chars = {0}", _counter);
        }
    }
}
