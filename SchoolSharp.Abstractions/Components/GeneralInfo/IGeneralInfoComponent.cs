using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Abstractions.Components.GeneralInfo
{
    public interface IGeneralInfoComponent : IClientComponent
    {
        Task<IEnumerable<IAnnouncment>> GetAnnouncments(int limit = 50);
    }
}
