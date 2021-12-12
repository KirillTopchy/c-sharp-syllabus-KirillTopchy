using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook
{
    public class PhoneDirectory
    {
        private readonly SortedDictionary<string, string> _data = new SortedDictionary<string, string>();

        public string GetNumber(string name)
        {
            return _data.ContainsKey(name) ? _data[name] : null;
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null) 
            {
                throw new Exception("name and number cannot be null");
            }
            if (!_data.ContainsKey(name))
            {
                _data.Add(name, number);
            }
            else
            {
                _data[name] = number;
            }
        }
    }
}