namespace Account
{
    class Account
    {
        private string Name { get; set; }
        private double Money { get; set; }

        public Account(string name, double money)
        {
            Name = name;
            Money = money;
        }

        public void Withdrawal(double amount)
        {
            Money -= amount;
        }

        public void Deposit(double amount)
        {
            Money += amount;
        }

        public override string ToString()
        {
            return $"{Name}: {Money}";
        }
    }
}
