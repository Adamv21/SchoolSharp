using JetBrains.Annotations;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Components
{
    public class WeekSchedule : BaseComponentInittiated, IWeekSchedule
    {
        private WeekSchedule(IClientComponent clientComponent, IDictionary<string, object> metadata) : base(clientComponent, metadata)
        {

        }

        public byte Week => (byte)Metadata.GetOrDefault(nameof(Week));
        public IEnumerable<IDaySchedule> Days => (IEnumerable<IDaySchedule>)Metadata.GetOrDefault(nameof(Days));


        public static WeekSchedule Build([NotNull] IClientComponent clientComponent, [NotNull] IDictionary<string, object> metadata,
            byte week, [NotNull] IEnumerable<IDaySchedule> days)
        {
            metadata.AddOrReplace(nameof(Week), week);
            metadata.AddOrReplace(nameof(Days), days.GuardNotNull(nameof(Days)));

            return new WeekSchedule(clientComponent, metadata); //Null checked in the constructor
        }
    }
}
