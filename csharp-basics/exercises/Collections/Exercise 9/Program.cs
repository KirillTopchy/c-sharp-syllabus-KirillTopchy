using System;
using System.Collections.Generic;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashSet = new HashSet<string>
            {
                "1",
                "2",
                "3",
                "4",
                "5"
            };

            foreach (var s in hashSet)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            hashSet.Clear();
            Console.WriteLine(hashSet.Count);

            hashSet.Add("1");
            hashSet.Add("1");

            foreach (var s in hashSet)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine(hashSet.Count);
            Console.ReadKey();
        }
    }
}
