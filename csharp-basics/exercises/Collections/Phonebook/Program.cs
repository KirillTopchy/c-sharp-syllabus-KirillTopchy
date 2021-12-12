using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new PhoneDirectory();
            phoneBook.PutNumber("Anton", "1223131");
            Console.WriteLine(phoneBook.GetNumber("Anton"));
            Console.ReadKey();
        }
    }
}
