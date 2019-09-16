using System.Collections.Generic;

namespace SchoolSharp.Abstractions.Components.Schedule
{
    public interface IDayEvent : IComponentInittiated
    {
        IDaySchedule Day { get; }
        string Name { get; }
        string Description { get; }
        IEnumerable<string> Hosts { get; }
    }
}