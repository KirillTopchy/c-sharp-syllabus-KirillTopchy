using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            var firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word:");
            var secondWord = Console.ReadLine();

            var result = firstWord;

            for (int i = firstWord.Length; i < 30-secondWord.Length; i++)
            {
                result += ".";
            }

            result += secondWord;
            Console.WriteLine(result);
        }
    }
}
