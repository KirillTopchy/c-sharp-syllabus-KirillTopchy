using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new BankAccount("Benson", -17.5);
            var user2 = new BankAccount("Tom", 17.5);
            Console.WriteLine(user1.ShowUserNameAndBalance());
            Console.WriteLine(user2.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
