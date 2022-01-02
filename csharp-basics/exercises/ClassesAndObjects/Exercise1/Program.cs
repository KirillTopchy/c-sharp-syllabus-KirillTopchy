using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product("Logitech mouse", 70.00, 14);
            var iPhone = new Product("iPhone 5s", 999.99, 3);
            var projector = new Product("Epson EB-U05", 440.46, 1);

            Console.WriteLine("Initial values.");
            Console.WriteLine(mouse.GetProduct());
            Console.WriteLine(iPhone.GetProduct());
            Console.WriteLine(projector.GetProduct());

            Console.WriteLine("Changed values.");
            mouse.Amount = 13;
            mouse.Price = 69.99;
            Console.WriteLine(mouse.GetProduct());

            iPhone.Amount = 4;
            iPhone.Price = 899.99;
            Console.WriteLine(iPhone.GetProduct());

            projector.Amount = 0;
            projector.Price = 599.99;
            Console.WriteLine(projector.GetProduct());
        }
    }
}