using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
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
