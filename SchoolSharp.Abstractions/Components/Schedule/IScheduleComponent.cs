using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Abstractions.Components
{
    public interface IScheduleComponent : IClientComponent
    {
        Task<IWeekSchedule> GetWeekScheduleAsync(byte week, ushort? term = null);

    }
}
