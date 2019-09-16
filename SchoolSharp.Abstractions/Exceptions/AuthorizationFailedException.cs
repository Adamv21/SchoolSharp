using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Exceptions
{
    public class AuthorizationFailedException : Exception
    {
        public AuthorizationFailedException()
        {
        }

        public AuthorizationFailedException(string message) : base(message)
        {
        }
    }
}
