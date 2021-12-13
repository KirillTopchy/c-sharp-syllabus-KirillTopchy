using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            colors.Insert(0,"Blue");

            Console.WriteLine(string.Join(",", colors));

            colors.Insert(0,"Pink");
            colors.Insert(2, "Brown");
            //Print the list
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
