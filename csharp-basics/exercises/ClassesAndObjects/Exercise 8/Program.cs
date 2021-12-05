using System;

namespace Exercise_8
{
    class Program
    {
        private static double _interestRate = 0.0;
        private static int _depositPeriodInMonths = 0;
        private static double _startBalance = 0;

        static void Main(string[] args)
        {
            InitialDepositInformation();
            var userStartBalance = new SavingsAccount(_startBalance);
            DepositsAndWithdrawalsDuringDepositPeriod(userStartBalance);
            AccountInfoAtTheEndOfDepositPeriod(userStartBalance);
        }

        public static void InitialDepositInformation()
        {
            Console.Write("How much money is in the account?: ");
            double.TryParse(Console.ReadLine(), out _startBalance);
            Console.Write("Enter the annual interest rate: ");
            double.TryParse(Console.ReadLine(), out _interestRate);
            Console.Write("How long has the account been opened?: ");
            int.TryParse(Console.ReadLine(), out _depositPeriodInMonths);
        }

        public static void DepositsAndWithdrawalsDuringDepositPeriod(SavingsAccount account)
        {
            for (int i = 0; i < _depositPeriodInMonths ; i++)
            {
                Console.Write("Enter amount deposited for month: {0}: ", i + 1);
                double.TryParse(Console.ReadLine(), out var deposit);
                account.Deposit(deposit);
                Console.Write("Enter amount withdrawn for month: {0}: ", i + 1);
                double.TryParse(Console.ReadLine(), out var withdraw);
                account.Withdrawal(withdraw);
                account.MonthlyInterest(_interestRate);
            }
        }

        public static void AccountInfoAtTheEndOfDepositPeriod(SavingsAccount account)
        {
            Console.WriteLine("Total deposited: {0:C2}", Convert.ToDecimal(account.GetDeposits()));
            Console.WriteLine("Total withdrawn: {0:C2}", Convert.ToDecimal(account.GetWithdrawals()));
            Console.WriteLine("Interest earned: {0:C2}", Convert.ToDecimal(account.MonthlyInterest(_interestRate)));
            Console.WriteLine("Ending balance: {0:C2}", Convert.ToDecimal(account.GetBalance()));
        }

    }
}
