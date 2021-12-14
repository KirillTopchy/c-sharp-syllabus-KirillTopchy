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
            mouse.PrintProduct();
            iPhone.PrintProduct();
            projector.PrintProduct();

            Console.WriteLine("Changed values.");
            mouse.Amount = 13;
            mouse.Price = 69.99;
            mouse.PrintProduct();

            iPhone.Amount = 4;
            iPhone.Price = 899.99;
            iPhone.PrintProduct();

            projector.Amount = 0;
            projector.Price = 599.99;
            projector.PrintProduct();
        }
    }
}