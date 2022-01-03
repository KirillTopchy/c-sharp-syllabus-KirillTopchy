using System;

namespace Exercise_2
{
    public class NotAnIntegerException : Exception
    {
        public NotAnIntegerException()
        {
        }

        public NotAnIntegerException(string message)
            : base(message)
        {
        }

        public NotAnIntegerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
