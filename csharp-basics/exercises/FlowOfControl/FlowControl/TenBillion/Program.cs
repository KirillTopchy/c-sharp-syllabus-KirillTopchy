using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Convert.ToInt64(Console.ReadLine());

            if (input < -2147483648 || input > 2147483647)
            {
                if (input < 0)
                {
                    input *= -1;
                }

                if (input > 10000000000)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }
                else
                {
                    var digits = 0;
                    while (input > 0)
                    {
                        input /= 10;
                        digits++;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            }
            else
            {
                Console.WriteLine("The number is not a long");
            }
            Console.ReadLine();
        }
    }
}
