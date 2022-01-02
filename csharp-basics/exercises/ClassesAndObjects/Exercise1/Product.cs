using System;

namespace Exercise1
{
    public class Product
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

        public string GetProduct()
        {
            return $"{_name}, price {_price}, amount {_amount}";
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
