using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class NumberIsNullException : Exception
    {
        public NumberIsNullException()
        {
        }

        public NumberIsNullException(string message) : base(message)
        {
        }

        public NumberIsNullException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
