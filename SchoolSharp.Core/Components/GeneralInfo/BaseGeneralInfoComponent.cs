using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Core.Components
{
    [AutoRegisterComponent(typeof(IGeneralInfoComponent))]
    public abstract class BaseGeneralInfoComponent : BaseClientComponent, IGeneralInfoComponent
    {
        protected BaseGeneralInfoComponent()
        {

        }
        public override string Name => nameof(IGeneralInfoComponent);

        public abstract Task<IEnumerable<IAnnouncement>> GetAnnouncmentsAsync(int limit);
    }
}
