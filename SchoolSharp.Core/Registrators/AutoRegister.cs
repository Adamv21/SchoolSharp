using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Registrators
{
    public abstract class AutoRegister : Attribute
    {
        public AutoRegister(params object[] args)
        {
            this.Args = args;
        }

        public object[] Args { get; }
    }
}
