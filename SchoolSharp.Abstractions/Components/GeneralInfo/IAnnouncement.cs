using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components
{
    public interface IAnnouncment : IComponentInittiated
    {
        string Title { get; }
        string Message { get; }
        IDictionary<string, object> Metadata { get; }
    }
}
