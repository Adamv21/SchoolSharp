using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components
{
    public interface IComponentInittiated
    {
        IClientComponent Source { get; }

        IDictionary<string, object> Metadata { get; set; }
    }
}
