using System;
using System.Linq;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of single digit number without spaces or any characters and symbols.");
            var enteredSeries = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            var sum = enteredSeries.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

            Console.WriteLine("You entered {0}, sum of its digits is {1}",enteredSeries,sum);
        }
    }
}
