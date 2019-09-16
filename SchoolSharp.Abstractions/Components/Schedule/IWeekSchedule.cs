using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Components
{
    public interface IWeekSchedule : IComponentInittiated
    {
        ushort Term { get; set; }
        byte Week { get; set; }
        IEnumerable<IDaySchedule> Days { get; }
    }
}
