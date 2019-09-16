using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core
{
    internal class SchoolPlatformLazyLoader<TComponent> : Lazy<TComponent> where TComponent : IClientComponent
    {

        public SchoolPlatformLazyLoader(ISchoolPlatformClient client) : base(() => client.GetComponent<TComponent>())
        {
            client.GuardNotNull(nameof(client));
        }
    }
}
