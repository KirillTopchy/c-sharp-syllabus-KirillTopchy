using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    class SavingsAccount
    {
        private double AnnualInterestRate { get; set; }
        private double Balance { get; set; }

        private double Deposits { get; set; }

        private double Withdrawals { get; set; }

        private double InterestEarned { get; set; }

        public SavingsAccount(double startBalance)
        {
            Balance = startBalance;
        }

        public double GetBalance()
        {
            Balance += InterestEarned;
            return Balance;
        }

        public double GetDeposits()
        {
            return Deposits;
        }

        public double GetWithdrawals()
        {
            return Withdrawals;
        }

        public double Withdrawal(double withdrawalAmount)
        {
            Withdrawals += withdrawalAmount;
            return Balance -= withdrawalAmount;
        }

        public double Deposit(double depositAmount)
        {
            Deposits += depositAmount;
            return Balance += depositAmount;
        }

        public double MonthlyInterest(double interestRate)
        {
            AnnualInterestRate = interestRate;
            return InterestEarned = Balance * AnnualInterestRate/12*4/100;
        }
    }
}
