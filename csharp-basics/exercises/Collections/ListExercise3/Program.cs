using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Write a C# program to insert an element into the array list at the first position.

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

            //TODO: Add new color at the first and third position of the list

            colors.Insert(0,"Pink");
            colors.Insert(2, "Brown");
            //Print the list
            Console.WriteLine(string.Join(",", colors));
            Console.ReadKey();
        }
    }
}
