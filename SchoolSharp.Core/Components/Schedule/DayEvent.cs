using JetBrains.Annotations;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System.Collections.Generic;

namespace SchoolSharp.Core.Components
{
    public class DayEvent : BaseComponentInittiated, IDayEvent
    {
        private DayEvent(IClientComponent component, IDictionary<string, object> metadata) : base(component, metadata)
        {
        }

        public IDaySchedule Day => (IDaySchedule)Metadata.GetOrDefault(nameof(Day));
        public string Name => (string)Metadata.GetOrDefault(nameof(Name));
        public string Description => (string)Metadata.GetOrDefault(nameof(Description));
        public IEnumerable<string> Hosts => (IEnumerable<string>)Metadata.GetOrDefault(nameof(Hosts));

        public static DayEvent Build([NotNull] IClientComponent component, [NotNull] IDictionary<string, object> metadata,
            IDaySchedule day, string name, string description,  [NotNull] IEnumerable<string> hosts)
        {
            metadata.AddOrReplace(nameof(Name), name);
            metadata.AddOrReplace(nameof(Day), day);
            metadata.AddOrReplace(nameof(Description), description);
            metadata.AddOrReplace(nameof(Hosts), hosts.GuardNotNull(nameof(hosts))); //Incase an error was made beforehand, we do not want to hide it via initiating a new IEnumrable.

            return new DayEvent(component, metadata); //Null checked in constructor
        }
    }
}