using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Abstractions.Components.Login;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Core.Components.Login
{
    [AutoRegisterComponent(typeof(ILoginComponent))]
    public abstract class BaseLoginComponent<TClient> : BaseClientComponent<TClient>, ILoginComponent
        where TClient : ISchoolPlatformClient
    {
        protected BaseLoginComponent(TClient client) : base(client)
        {

        }

        public override string Name => nameof(ILoginComponent);

        public abstract Task<LoginResult> LoginAsync(UserCrededentials crededentials);
    }
}
