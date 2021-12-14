using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
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

            stringList.Insert(4,"aa");
            stringList[stringList.Count - 1] = "TEST";
            stringList.Sort();
            var contains = stringList.Contains("Foobar");
            Console.WriteLine(contains);

            foreach (var s in stringList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
