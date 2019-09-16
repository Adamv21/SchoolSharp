using SchoolSharp.Abstractions.Components;
using SchoolSharp.Core.Components;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Platform.SchoolSoft.Components.Schedule
{
    public class SchoolSoftScheduleComponent : BaseScheduleComponent<SchoolSoftSchoolPlatformClient>
    {
        public SchoolSoftScheduleComponent(SchoolSoftSchoolPlatformClient client) : base(client)
        {
        }

        public override Task<IWeekSchedule> GetWeekScheduleAsync(byte week, ushort? term = null)
        {
            string scheduleUrl 
        }
    }
}
