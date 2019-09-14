using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Modules
{
    public interface IGeneralInfoComponent : IClientComponent
    {

    }

    public abstract class BaseGeneralInfoComponent : BaseClientComponent, IGeneralInfoComponent
    {
        public override string Name => nameof(IGeneralInfoComponent);
    }
}
