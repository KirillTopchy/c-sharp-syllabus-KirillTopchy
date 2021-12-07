﻿using System;

namespace Exercise_6
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a max value as an integer");
            var enteredInteger = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= enteredInteger; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0) 
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                if (i % 20 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
