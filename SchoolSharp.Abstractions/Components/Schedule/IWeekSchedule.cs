using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components
{
    public interface IWeekSchedule : IComponentInittiated
    {
        ushort Term { get; }
        byte Week { get; }
        IEnumerable<IDaySchedule> Days { get; }
    }
}
