using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Abstractions.Components.Schedule
{
    public interface IScheduleComponent : IClientComponent
    {
        Task<IWeekSchedule> GetWeekScheduleAsync(byte week, ushort? term = null);

    }
}
