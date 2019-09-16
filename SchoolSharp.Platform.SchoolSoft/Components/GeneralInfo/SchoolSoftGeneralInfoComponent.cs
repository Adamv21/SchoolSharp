using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components.GeneralInfo;
using SchoolSharp.Core.Components.GeneralInfo;
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


        public async override Task<IEnumerable<IAnnouncment>> GetAnnouncments(int limit)
        {
            throw new NotImplementedException();
        }
    }
}
