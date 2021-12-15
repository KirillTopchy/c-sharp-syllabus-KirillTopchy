using System;

namespace Exercise_3
{
    class Employee : Person
    {
        private string _jobTitle;

        public Employee(string jobTitle, string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
            _jobTitle = jobTitle;
        }

        public string JobTitle
        {
            get => _jobTitle;
            set => _jobTitle = value;
        }

        public override void Display()
        {
            Console.WriteLine($"First name: {FirstName} \nLast name: {LastName} \nAddress: {Address} \nID: {Id} \nJob title: {JobTitle}");
        }
    }
}
