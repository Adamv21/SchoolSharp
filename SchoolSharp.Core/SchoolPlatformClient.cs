using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Exceptions;
using SchoolSharp.Abstractions.Modules;
using SchoolSharp.Common.Extensions;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core
{


    public class SchoolPlatformClient : ISchoolPlatformClient
    {
        public SchoolPlatformClient(IComponentRegistrator registrator)
        {

            registrator.GuardNotNull(nameof(registrator));

            var findings = registrator.GatherFittings(this);

            foreach(var finding in findings)
            {
                Components.Add(finding.InterfaceType, (IClientComponent)Activator.CreateInstance(finding.ImplementationType, this));
            }

            generalInfoLoader = new SchoolPlatformLazyLoader<IGeneralInfoComponent>(this);

        }

        public IDictionary<Type, IClientComponent> Components { get; } = new Dictionary<Type, IClientComponent>();

        public IGeneralInfoComponent GeneralInfoComponent => generalInfoLoader.Value;



        private SchoolPlatformLazyLoader<IGeneralInfoComponent> generalInfoLoader;

        public TComponent GetComponent<TComponent>() where TComponent : IClientComponent
        {
            if (!Components.TryGetValue(typeof(TComponent), out var value))
                throw new ComponentNotRegistredException(typeof(TComponent));

            return (TComponent)value;
        }
    }
}
