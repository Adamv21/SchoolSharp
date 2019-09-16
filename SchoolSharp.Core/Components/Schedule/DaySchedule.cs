using JetBrains.Annotations;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SchoolSharp.Core.Components
{
    public class DaySchedule : BaseComponentInittiated, IDaySchedule
    {
        public DaySchedule(IClientComponent source, IDictionary<string, object> metadata) : base(source, metadata)
        {

        }

        public IWeekSchedule Week => (IWeekSchedule)Metadata.GetOrDefault(nameof(Week));
        public DayOfWeek Day => (DayOfWeek)Metadata.GetOrDefault(nameof(Day));
        public IEnumerable<IDayEvent> Events => (IEnumerable<IDayEvent>)Metadata.GetOrDefault(nameof(IDayEvent));

        public static DaySchedule Build([NotNull] IClientComponent clientComponent, [NotNull] IDictionary<string, object> metadata,
            IWeekSchedule week, DayOfWeek day,  IEnumerable<IDayEvent> events)
        {
            metadata.AddOrReplace(nameof(week), week);
            metadata.AddOrReplace(nameof(day), day);
            metadata.AddOrReplace(nameof(events), events);

            return new DaySchedule(clientComponent, metadata);
        }
    }
}