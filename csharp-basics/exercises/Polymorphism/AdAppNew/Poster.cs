namespace AdApp
{
    class Poster : Advert
    {
        private double _width;
        private double _height;
        private int _quantity;
        private double _cost;

        public Poster(int fee, double width, double height, int quantity, double cost) : base(fee)
        {
            _width = width;
            _height = height;
            _quantity = quantity;
            _cost = cost;
        }

        public new int Cost()
        {
            return base.Cost();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
