using System;

namespace CalculateArea
{
    public class Geometry
    {
        public static double AreaOfCircle(decimal radius)
        {
            if (radius < 0)
            {
                Console.WriteLine("Wrong input, only positive values are acceptable.");
                return -1;
            }
            var area = Math.Round((Math.PI * (double) radius * (double) radius),2);
            return area;
        }

        public static double AreaOfRectangle(decimal length, decimal width)
        {
            if (length < 0 || width < 0)
            {
                Console.WriteLine("Wrong input, only positive values are acceptable.");
                return -1;
            }
            var area = Math.Round((length * width),2);
            return (double) area;
        }

        public static double AreaOfTriangle(decimal ground, decimal height)
        {
            if (ground < 0 || height < 0)
            {
                Console.WriteLine("Wrong input, only positive values are acceptable.");
                return -1;
            }
            var area = Math.Round((double) (ground * height * (decimal) 0.5),2);
            return area;
        }
    }
}
