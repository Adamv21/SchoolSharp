using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Registrators
{
    public struct ComponentRegistrationInfo
    {
        public Type ImplementationType { get; set; }
        public Type InterfaceType { get; set; }
    }
}
