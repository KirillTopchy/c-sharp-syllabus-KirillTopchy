using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _id;

        public Person()
        {

        }

        public Person(string firstName, string lastName, string address, int id)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _id = id;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _firstName = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public virtual void Display()
        {
            Console.WriteLine($"First name: {FirstName} \nLast name: {LastName} \nAddress: {Address} \nID: {Id}");
        }
    }
}
