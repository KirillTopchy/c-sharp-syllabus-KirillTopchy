using System;

namespace Exercise_2
{
    class Program
    {
       //Write a program called CheckOddEven which prints "Odd Number" if the int variable “number” is odd, or “Even Number” otherwise.
       //The program shall always print “bye!” before exiting.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your integer number");
            var userEnteredInteger = Convert.ToInt32(Console.ReadLine());
            CheckOddEven(userEnteredInteger);
            Console.WriteLine("bye!");
        }

        public static void CheckOddEven(int a)
        {
            Console.WriteLine(a % 2 == 0 ? "Even number" : "Odd number");
        }
    }
}
