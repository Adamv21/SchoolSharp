using SchoolSharp.Abstractions.Components;
using SchoolSharp.Abstractions.Components.GeneralInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions
{
    public interface ISchoolPlatformClient
    {
        UserCrededentials Crededentials { get; }

        IGeneralInfoComponent GeneralInfoComponent { get; }

        TComponent GetComponent<TComponent>() where TComponent : IClientComponent;
    }
}
