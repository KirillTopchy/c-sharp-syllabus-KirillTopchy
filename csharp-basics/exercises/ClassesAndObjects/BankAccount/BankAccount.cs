using System;

namespace BankAccount
{
    class BankAccount
    {
        private readonly string _name;
        private readonly double _balance;

        public BankAccount(string name, double balance)
        {
            _name = name;
            _balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance < 0)
            {
                const string fmt1 = "#,##0.00";
                var output = _name + ", -$" + Math.Abs(_balance).ToString(fmt1);
                return output;
            }
            return $"{_name}, {_balance:C2}";
        }

    }
}
