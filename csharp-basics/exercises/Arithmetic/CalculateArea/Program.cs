using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the user's menu choice.
           var userChorusedOption = GetMenu();
           switch (userChorusedOption)
           {
               case 1:
                   CalculateCircleArea();
                   Console.ReadKey();
                   break;
               case 2:
                   CalculateRectangleArea();
                    Console.ReadKey();
                    break;
               case 3:
                   CalculateTriangleArea();
                    Console.ReadKey();
                    break;
               default:
                   Environment.Exit(0);
                   break;
           }
        }

        public static int GetMenu()
        {
            var userChoice = 0;
            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            // get input from user

            var keyboard = Console.ReadKey();
            Console.WriteLine();

            // validate input
            while (keyboard.KeyChar < '1' || keyboard.KeyChar >'4')
            {
                Console.WriteLine("Wrong input.");
                Console.WriteLine("Enter your choice (1-4) : ");
                keyboard = Console.ReadKey();
            }
            userChoice = Convert.ToInt32(Convert.ToString(keyboard.KeyChar));
            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            var radiusEntered = Console.ReadLine();

            decimal.TryParse(radiusEntered, out var radius);

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            // Get length
            Console.WriteLine("Enter length? ");
            var lengthEntered = Console.ReadLine();

            decimal.TryParse(lengthEntered, out var length);

            // Get width
            Console.WriteLine("Enter width? ");
            var widthEntered = Console.ReadLine();

            decimal.TryParse(widthEntered, out var width);


            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {

            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            var groundEntered = Console.ReadLine();

            decimal.TryParse(groundEntered, out var ground);

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            var heightEntered = Console.ReadLine();

            decimal.TryParse(heightEntered, out var height);

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
