using System;

namespace Account.Exceptions
{
    public class NegativeDepositException : Exception
    {
        public NegativeDepositException()
        {
        }

        public NegativeDepositException(string message)
            : base(message)
        {
        }

        public NegativeDepositException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
