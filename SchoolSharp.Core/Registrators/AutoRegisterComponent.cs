using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Registrators
{
    public class AutoRegisterComponent : AutoRegister
    {
        public AutoRegisterComponent(Type interfaceType) : base(interfaceType)
        {

        }

        public Type InterfaceType => (Type)Args[0];
    }
}
