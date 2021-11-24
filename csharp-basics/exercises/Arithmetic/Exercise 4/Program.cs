using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (var i = 1; i < 10; i++)
            {
                result += result * i;
            }
            Console.WriteLine("10! = {0}", result);
        }
    }
}
