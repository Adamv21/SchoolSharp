using SchoolSharp.Common.Builders;
using SchoolSharp.Platform.SchoolSoft.HttpMessageHandlers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SchoolSharp.Platform.SchoolSoft.Builders
{
    internal class SchoolSoftNavigatorBuilder : BaseBuilder<HttpClient>
    {
        private readonly SchoolSoftSchoolPlatformClient client;
        public SchoolSoftNavigatorBuilder(SchoolSoftSchoolPlatformClient client)
        {
            this.client = client; 
        }
        public override HttpClient Build()
        {
            var httpClient = new HttpClient(new SchoolsoftUserStateCheckMessageHandler(client));

            httpClient.BaseAddress = new Uri($"https://sms1.schoolsoft.se/{client.Crededentials.School}/jsp");

            return httpClient;
        }
    }
}
