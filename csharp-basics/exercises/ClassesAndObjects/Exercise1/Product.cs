using System;

namespace Exercise1
{
    class Product
    {
        private double _price;
        private int _amount;
        private readonly string _name;

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            _name = name;
            _amount = amountAtStart;
            _price = priceAtStart;
        }

        public void PrintProduct()
        {
            Console.WriteLine("{0}, price {1}, amount {2}", _name, _price, _amount);
        }

        public int Amount
        {
            set => _amount = value;
        }

        public double Price
        {
            set => _price = value;
        }

    }
}
