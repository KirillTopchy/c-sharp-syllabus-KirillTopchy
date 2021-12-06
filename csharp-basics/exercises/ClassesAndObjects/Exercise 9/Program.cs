using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(5, 2);
            var p2 = new Point(-3, 6);
            p1.SwapPoints(p1,p2);
            Console.WriteLine("(" + p1.GetX() + ", " + p1.GetY() + ")");
            Console.WriteLine("(" + p2.GetX() + ", " + p2.GetY() + ")");
        }
    }
}
