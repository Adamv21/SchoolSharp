using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Core.Components;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSharp.Platform.SchoolSoft.Components
{   
    public class SchoolSoftGeneralInfoComponent : BaseGeneralInfoComponent<SchoolSoftSchoolPlatformClient>
    {
        public SchoolSoftGeneralInfoComponent(SchoolSoftSchoolPlatformClient client) : base(client)
        {
        }


        public async override Task<IEnumerable<IAnnouncement>> GetAnnouncmentsAsync(int limit)
        {
            throw new NotImplementedException();
        }
    }
}
