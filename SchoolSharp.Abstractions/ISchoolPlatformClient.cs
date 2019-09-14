using SchoolSharp.Abstractions.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions
{
    public interface ISchoolPlatformClient
    {
        IGeneralInfoComponent GeneralInfoComponent { get; }

        TComponent GetComponent<TComponent>() where TComponent : IClientComponent;
    }
}
