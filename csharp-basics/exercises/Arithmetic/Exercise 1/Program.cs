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

            var finalResult = IntegerAnalyzer.CompareIntegers(firstInt, secondInt);

            Console.WriteLine(finalResult);
        }
    }
}
