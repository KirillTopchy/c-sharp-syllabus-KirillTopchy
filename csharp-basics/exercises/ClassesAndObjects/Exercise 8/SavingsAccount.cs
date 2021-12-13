namespace Exercise_8
{
    class SavingsAccount
    {
        private double _annualInterestRate;
        private double _balance;
        private double _deposits;
        private double _withdrawals;
        private double _interestEarned;

        public SavingsAccount(double startBalance)
        {
            _balance = startBalance;
        }

        public double GetBalance()
        {
            _balance += _interestEarned;
            return _balance;
        }

        public double GetDeposits()
        {
            return _deposits;
        }

        public double GetWithdrawals()
        {
            return _withdrawals;
        }

        public double Withdrawal(double withdrawalAmount)
        {
            _withdrawals += withdrawalAmount;
            return _balance -= withdrawalAmount;
        }

        public double Deposit(double depositAmount)
        {
            _deposits += depositAmount;
            return _balance += depositAmount;
        }

        public double MonthlyInterest(double interestRate)
        {
            _annualInterestRate = interestRate;
            return _interestEarned = _balance * _annualInterestRate/12*4/100;
        }
    }
}
