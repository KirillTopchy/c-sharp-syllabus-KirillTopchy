namespace Exercise_6
{
    abstract class Food
    {
        private int _quantity;

        protected Food(int quantity)
        {
            _quantity = quantity;
        }

        public int FoodQuantity
        {
            get => _quantity;
        }
    }
}
