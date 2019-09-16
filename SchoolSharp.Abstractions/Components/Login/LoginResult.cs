using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components.Login
{
    public struct LoginResult
    {
        internal LoginResult(bool success)
        {
            this.Success = success;
        }
        public bool Success { get; }

        public static LoginResult Build(bool success)
            => new LoginResult(success);
    }
}
