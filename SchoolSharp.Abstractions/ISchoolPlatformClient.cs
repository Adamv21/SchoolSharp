using SchoolSharp.Abstractions.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions
{
    public interface ISchoolPlatformClient
    {
        UserCrededentials Crededentials { get; }

        IGeneralInfoComponent GeneralInfoComponent { get; }

        IScheduleComponent ScheduleComponent { get; }
        TComponent GetComponent<TComponent>();
    }
}
