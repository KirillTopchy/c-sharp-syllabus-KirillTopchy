using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = 1;

            Console.WriteLine("Input number of terms : ");
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                power *= n;
                Console.WriteLine("n = {0}, i = {1}, n^i = {2}", n, i, power);
            }

            Console.ReadKey();
        }
    }
}
