using System;
using System.Data;
using Account.Exceptions;

namespace Account
{
    public class Account
    {
        private readonly string _name;
        private decimal _money;

        public Account(string name, decimal money)
        {
            _name = name;
            _money = money;
        }

        public void Withdrawal(decimal amount)
        {
            if (amount <= _money)
            {
                _money -= amount;
            }
            else
            {
                throw new InsufficientFundsException("Insufficient funds");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _money += amount;
            }
            else
            {
                throw new NegativeDepositException("Impossible to make negative deposit");
            }
        }

        public override string ToString()
        {
            return $"{_name}: {_money}";
        }

        public decimal GetBalance()
        {
            return _money;
        }
    }
}
