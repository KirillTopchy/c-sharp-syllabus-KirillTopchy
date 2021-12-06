using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Point
    {
        private int X { get; set; }
        private int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void SwapPoints(Point p1, Point p2)
        {
            var xHolder = p1.X;
            var yHolder = p1.Y;
            p1.Y = p2.Y;
            p1.X = p2.X;
            p2.Y = yHolder;
            p2.X = xHolder;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
