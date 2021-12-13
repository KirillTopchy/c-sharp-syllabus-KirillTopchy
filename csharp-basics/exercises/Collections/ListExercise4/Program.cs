using System;
using System.Collections.Generic;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            var element = "Blue";
            colors.Add(element);
            Console.WriteLine("First element: " + element);
            
            element = "Brown";
            colors.Add(element);
            Console.WriteLine("Third element: " + element);
            Console.ReadKey();
        }
    }
}
