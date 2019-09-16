using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Core.Components
{
    [AutoRegisterComponent(typeof(ILoginComponent))]
    public abstract class BaseLoginComponent : BaseClientComponent, ILoginComponent
    {
        protected BaseLoginComponent()
        {

        }

        public override string Name => nameof(ILoginComponent);

        public abstract Task<LoginResult> LoginAsync(UserCrededentials crededentials);
    }
}
