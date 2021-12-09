using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Create a list and add some colors to the list
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
