using SchoolSharp.Abstractions;
using SchoolSharp.Core;
using SchoolSharp.Core.Registrators;
using SchoolSharp.Platform.SchoolSoft.HttpMessageHandlers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SchoolSharp.Platform.SchoolSoft
{
    public class SchoolSoftSchoolPlatformClient : BaseSchoolPlatformClient
    {
        public SchoolSoftSchoolPlatformClient(UserCrededentials userCrededentials, IComponentRegistrator registrator) : base(userCrededentials, registrator)
        {
            Navigator = new HttpClient(new SchoolsoftUserStateCheckMessageHandler(this));
        }

        public HttpClient Navigator { get; }
    }
}
