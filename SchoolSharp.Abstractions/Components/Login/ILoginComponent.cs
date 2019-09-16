using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Abstractions.Components
{
    public interface ILoginComponent : IClientComponent
    {
        Task<LoginResult> LoginAsync(UserCrededentials crededentials);
    }
}
