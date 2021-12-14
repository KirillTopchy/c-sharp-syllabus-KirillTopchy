using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputIsEmplty = false;
            var names = new HashSet<string>();
            while (inputIsEmplty == false)
            {
                Console.Write("Enter name : ");
                var input = Console.ReadLine();
                if (input == "")
                {
                    inputIsEmplty = true;
                    Console.Write("Unique name list contains: ");
                    foreach (var name in names)
                    {
                        Console.Write(name + " ");
                    }    
                }
                names.Add(input);
            }
        }
    }
}
