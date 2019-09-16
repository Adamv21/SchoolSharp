using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Components
{
    public abstract class BaseClientComponent<TClient> : IClientComponent 
        where TClient : ISchoolPlatformClient
    {
        protected BaseClientComponent(TClient client)
        {
            client.GuardNotNull(nameof(client));
            this.SchoolClient = client;
        }

        public ISchoolPlatformClient Client => SchoolClient;

        public TClient SchoolClient { get; }

        public abstract string Name { get; }
    }
}
