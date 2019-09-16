using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Abstractions.Components.GeneralInfo;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Core.Components.GeneralInfo
{
    [AutoRegisterComponent(typeof(IGeneralInfoComponent))]
    public abstract class BaseGeneralInfoComponent<TClient> : BaseClientComponent<TClient>, IGeneralInfoComponent where TClient : ISchoolPlatformClient
    {
        protected BaseGeneralInfoComponent(TClient client) : base(client)
        {

        }
        public override string Name => nameof(IGeneralInfoComponent);

        public abstract Task<IEnumerable<IAnnouncment>> GetAnnouncments(int limit);
    }
}
