using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string Name { get; set; }
        private  double Balance { get; set; }

        public BankAccount(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

        public string ShowUserNameAndBalance()
        {
            if (Balance < 0)
            {
                const string fmt1 = "#,##0.00";
                var output = Name.ToString() + ", -$" + Math.Abs(Balance).ToString(fmt1);
                return output;
            }
            return $"{Name}, {Balance:C2}";
        }

    }
}
