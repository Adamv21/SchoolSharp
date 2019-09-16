using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components
{
    public interface IWeekSchedule : IComponentInittiated
    {
        byte Week { get; }
        IEnumerable<IDaySchedule> Days { get; }
    }
}
