using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            var enteredString = Console.ReadLine();
            var characters = enteredString.ToCharArray();
            var counter = 0;

            foreach (var item in characters)
            {
                if (char.IsUpper((item)))
                {
                    counter++;
                }
            }
            Console.WriteLine("In your string found {0} uppercase letters", counter);
        }
    }
}
