using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Create an List with string elements
            //TODO: Add 10 values to list
            var stringList = new List<string> 
            {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
                "g",
                "h",
                "i",
                "j"
            };

            //TODO: Add new value at 5th position
            stringList.Insert(4,"aa");

            //TODO: Change value at last position (Calculate last position programmatically)
            stringList[stringList.Count - 1] = "TEST";

            //TODO: Sort your list in alphabetical order
            stringList.Sort();

            //TODO: Check if your list contains "Foobar" element
            var contains = stringList.Contains("Foobar");
            Console.WriteLine(contains);

            //TODO: Print each element of list using loop
            foreach (var s in stringList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
