using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Abstractions.Components.GeneralInfo;
using SchoolSharp.Abstractions.Exceptions;
using SchoolSharp.Common.Extensions;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core
{


    public abstract class BaseSchoolPlatformClient : ISchoolPlatformClient
    {
        public BaseSchoolPlatformClient(UserCrededentials userCrededentials, IComponentRegistrator registrator)
        {

            registrator.GuardNotNull(nameof(registrator));

            this.Crededentials = userCrededentials;

            var findings = registrator.GatherFittings(this);

            foreach(var finding in findings)
            {
                Components.Add(finding.InterfaceType, (IClientComponent)Activator.CreateInstance(finding.ImplementationType, this));
            }

            generalInfoLoader = new SchoolPlatformLazyLoader<IGeneralInfoComponent>(this);

        }

        public IDictionary<Type, IClientComponent> Components { get; } = new Dictionary<Type, IClientComponent>();

        public IGeneralInfoComponent GeneralInfoComponent => generalInfoLoader.Value;

        public UserCrededentials Crededentials { get; }
        IGeneralInfoComponent ISchoolPlatformClient.GeneralInfoComponent { get; }

        private SchoolPlatformLazyLoader<IGeneralInfoComponent> generalInfoLoader;

        public TComponent GetComponent<TComponent>() where TComponent : IClientComponent
        {
            if (!Components.TryGetValue(typeof(TComponent), out var value))
                throw new ComponentNotRegistredException(typeof(TComponent));

            return (TComponent)value;
        }
    }
}
