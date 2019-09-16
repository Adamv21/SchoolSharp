using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components
{
    public interface IAnnouncement : IComponentInittiated
    {
        string Title { get; }
        string Message { get; }
    }
}
