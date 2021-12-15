using System;

namespace Exercise_3
{
    class Student : Person
    {
        private double _gpa;

        public Student(double gpa, string firstName, string lastName, string address, int id) : base(firstName, lastName, address, id)
        {
            _gpa = gpa;
        }

        public double Gpa
        {
            get => _gpa;
            set => _gpa = value;
        }

        public override void Display()
        {
            Console.WriteLine($"First name: {FirstName} \nLast name: {LastName} \nAddress: {Address} \nID: {Id} \nGPA: {Gpa}");
        }
    }
}
