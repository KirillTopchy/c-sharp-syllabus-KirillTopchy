using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            var position = Array.IndexOf(myArray,1245);

            if (position > -1)
            {
                Console.WriteLine("Item found at {0} position in array", position);
            }
            else
            {
                Console.WriteLine("Item not found");
            }
            Console.ReadKey();
        }
    }
}
