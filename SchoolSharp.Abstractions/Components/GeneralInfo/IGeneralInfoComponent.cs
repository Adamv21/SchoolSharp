using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Abstractions.Components
{
    public interface IGeneralInfoComponent : IClientComponent
    {
        Task<IEnumerable<IAnnouncement>> GetAnnouncmentsAsync(int limit = 50);
    }
}
