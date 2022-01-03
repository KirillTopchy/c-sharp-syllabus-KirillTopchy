using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your integer number");
            var userInput = Console.ReadLine();
            var result = CheckOddEven.ParseInputToInteger(userInput);
            Console.WriteLine(CheckOddEven.OddOrEven(result));
            Console.WriteLine("bye!");
        }
    }
}
