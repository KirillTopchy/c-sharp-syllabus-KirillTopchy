namespace Exercise_9
{
    class Point
    {
        private int _x;
        private int _y;
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void SwapPoints(Point p1, Point p2)
        {
            var xHolder = p1._x;
            var yHolder = p1._y;
            p1._y = p2._y;
            p1._x = p2._x;
            p2._y = yHolder;
            p2._x = xHolder;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }
    }
}
