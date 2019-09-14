using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Exceptions
{
    public class ComponentNotRegistredException : Exception
    {
        public ComponentNotRegistredException(Type componentType) : base($"The component type {componentType.Name} was not registred!")
        {

        }
    }
}
