using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class Counter
    {
        private static int _counter;


        public static int CountLines(string path)
        {
            _counter = 0;
            foreach (var line in File.ReadLines(path))
            {
                _counter++;
            }

            return _counter;
        }

        public static int CountWords(string path)
        {
            _counter = 0;
            foreach (var word in File.ReadLines(path))
            {
                // replace multiple spaces with single one and split string by space.
                var spited = Regex.Replace(word, @"\s+", " ").Split(' ');
                for (int i = 0; i < spited.Length; i++)
                {
                    _counter++;
                }
            }

            return _counter;
        }

        public static int CountChars(string path)
        {
            _counter = 0;
            foreach (var c in File.ReadAllText(path).Where(char.IsLetterOrDigit))
            {
                _counter++;
            }

            return _counter;
        }
    }
}
