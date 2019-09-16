using SchoolSharp.Abstractions;
using SchoolSharp.Core;
using SchoolSharp.Core.Registrators;
using SchoolSharp.Platform.SchoolSoft.Builders;
using SchoolSharp.Platform.SchoolSoft.HttpMessageHandlers;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SchoolSharp.Platform.SchoolSoft
{
    public class SchoolSoftSchoolPlatformClient : BaseSchoolPlatformClient
    {
        public SchoolSoftSchoolPlatformClient(UserCrededentials userCrededentials) : base(userCrededentials)
        {
            var assemblyBuilder = new AssemblyComponentRegistrator(typeof(SchoolSoftSchoolPlatformClient).Assembly); //Registers all componenets etc
            var navigatorRegistrator = new InstanceComponentRegistrator<HttpClient>(new SchoolSoftNavigatorBuilder(this)); //Register http client navigator

            BuildContainer(assemblyBuilder, navigatorRegistrator);
        }

        public string BaseUrl => $"https://sms1.schoolsoft.se/{Crededentials.School}/jsp";
    }
}
