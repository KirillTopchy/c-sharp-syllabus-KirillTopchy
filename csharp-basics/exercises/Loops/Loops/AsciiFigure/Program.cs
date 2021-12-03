using System;

namespace AsciiFigure
{
    class Program
    {
        private static int _size;
        public static void Main(string[] args)
        {
            UserInput();
            DrawFigure(_size);
        }

        public static void UserInput()
        {
            Console.Write("Enter size of figure: ");
            int.TryParse(Console.ReadLine(), out _size);
        }

        public static void DrawFigure(int size)
        {
            DrawFirstLine();
            var result = "";
            var starLength = 8;
            var slashLength = (size-2)*4;

            for (int i = 2; i < size; i++)
            {
                for (int slash1 = 1; slash1 <= slashLength; slash1++)
                {
                    result += "/";
                }
                for (int star = 1; star <= starLength; star++)
                {
                        result += "*";
                }
                for (int slash2 = 1; slash2 <= slashLength; slash2++)
                {
                        result += "\\";
                }
                Console.Write(result);
                Console.WriteLine();
                result = "";
                slashLength -= 4;
                starLength += 8;
            }
            DrawLastLine();
        }
        
        public static void DrawFirstLine()
        {
            var result = "";
            while (result.Length < (_size - 1) * 8 / 2)
            {
                result += "/";
            }
            while (result.Length != (_size - 1) * 8)
            {
                result += "\\";
            }
            Console.Write(result);
            Console.WriteLine();
        }

        public static void DrawLastLine()
        {
            var result = "";
            while (result.Length < (_size - 1) * 8)
            {
                result += "*";
            }
            Console.Write(result);
            Console.WriteLine();
        }
    }
}
