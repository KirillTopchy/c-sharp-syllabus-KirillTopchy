using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Exceptions
{
    public class NameIsNullException : Exception
    {
        public NameIsNullException()
        {
        }

        public NameIsNullException(string message) : base(message)
        {
        }

        public NameIsNullException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
