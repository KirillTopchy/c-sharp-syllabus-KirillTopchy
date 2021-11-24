using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer");
            var firstInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            var secondInt = Convert.ToInt32(Console.ReadLine());

            var finalResult = IntegerAnalyzer(firstInt, secondInt);

            Console.WriteLine(finalResult ? "True" : "False");
        }

        public static bool IntegerAnalyzer(int a, int b)
        {
            return a == 15 || b == 15 || a + b == 15 ||
                    a - b == 15 || b - a == 15;
        }
    }
}
