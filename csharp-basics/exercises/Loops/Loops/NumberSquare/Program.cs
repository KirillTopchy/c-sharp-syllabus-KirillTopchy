using System;
using System.Globalization;

namespace NumberSquare
{
    class Program
    {
        private static int _min;
        private static int _max;
        private static int _localMin;

        public static void Main(string[] args)
        {
            UserInput();
            PrintNumbers();
        }

        public static void UserInput()
        {
            Console.Write("Enter min value: ");
            int.TryParse(Console.ReadLine(), out _min);
            Console.Write("Enter max value: ");
            int.TryParse(Console.ReadLine(), out _max);
            _localMin += _min;
        }

        public static void PrintNumbers()
        {
            var result = "";
            for (int i = _min; i <= _max; i++)
            {
                for (int j = _min; j <= _max; j++)
                {
                    result += j;
                }
                Console.Write(result);
                var min = _localMin;
                while (result.Length < _max)
                {
                    result += min;
                    Console.Write(min);
                    min++;
                }
                result = "";
                _min ++;
                Console.WriteLine();
            }
        }
    }
}
