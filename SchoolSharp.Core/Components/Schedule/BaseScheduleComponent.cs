using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Core.Components
{
    public abstract class BaseScheduleComponent<TClient> : BaseClientComponent<TClient>, IScheduleComponent where TClient : ISchoolPlatformClient
    {
        protected BaseScheduleComponent(TClient client) : base(client)
        {

        }

        public override string Name => nameof(IScheduleComponent);

        public abstract Task<IWeekSchedule> GetWeekScheduleAsync(byte week, ushort? term = null);
    }
}
