using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolSharp.Abstractions.Components
{
    public interface IDaySchedule : IComponentInittiated
    {
        IWeekSchedule Week { get; }
        DayOfWeek Day { get; }

        IEnumerable<IDayEvent> Events { get; }
    }
}