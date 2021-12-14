namespace Account
{
    class Account
    {
        private readonly string _name;
        private double _money;

        public Account(string name, double money)
        {
            _name = name;
            _money = money;
        }

        public void Withdrawal(double amount)
        {
            _money -= amount;
        }

        public void Deposit(double amount)
        {
            _money += amount;
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }
    }
}
