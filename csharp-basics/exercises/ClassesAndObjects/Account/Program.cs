using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var firstAccount = new Account("Kirill's account", 100.0m);
            firstAccount.Deposit(20);
            Console.WriteLine(firstAccount.ToString());
            Console.WriteLine();

            var mattAccount = new Account("Matt's account", 1000);
            var myAccount = new Account("My account", 0);
            mattAccount.Withdrawal(100);
            myAccount.Deposit(100);
            Console.WriteLine(mattAccount.ToString());
            Console.WriteLine(myAccount.ToString());
            Console.WriteLine();

            var a = new Account("A", 100);
            var b = new Account("B", 0);
            var c = new Account("C", 0);
            Transfer.MoneyTransfer(a,b,50);
            Transfer.MoneyTransfer(b,c,25);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}
