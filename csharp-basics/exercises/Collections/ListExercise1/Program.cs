using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to create a new list, add some elements (string) and print out the collection.
            //TODO: Add 5 colors to list
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Black",
                "Blue",
                "Yellow"
            };

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadKey();
        }
    }
}
