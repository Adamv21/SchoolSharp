using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Modules
{

    public interface IClientComponent
    {
        string Name { get; }
    }

    public abstract class BaseClientComponent : IClientComponent
    {
        public abstract string Name { get; }
    }
}
