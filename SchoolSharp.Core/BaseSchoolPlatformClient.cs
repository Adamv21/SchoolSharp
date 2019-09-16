using Autofac;
using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Abstractions.Exceptions;
using SchoolSharp.Abstractions.Registrators;
using SchoolSharp.Common.Extensions;
using SchoolSharp.Core.Registrators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core
{


    public abstract class BaseSchoolPlatformClient : ISchoolPlatformClient
    {
        public BaseSchoolPlatformClient(UserCrededentials userCrededentials)
        {

            this.Crededentials = userCrededentials;
        }

        public IContainer Container { get; private set; }

        public UserCrededentials Crededentials { get; }
        public IGeneralInfoComponent GeneralInfoComponent => Container.Resolve<IGeneralInfoComponent>();

        public IScheduleComponent ScheduleComponent => Container.Resolve<IScheduleComponent>();

        protected void BuildContainer(params IComponentRegistrator[] registrators)
        {
            if (Container != null)
                throw new Exception("Already initiated!");

            var builder = new ContainerBuilder();
            registrators.GuardNotNull(nameof(registrators));

            foreach (var registrator in registrators)
                registrator.Register(builder);

            Container = builder.Build();

        }

        public TComponent GetComponent<TComponent>()
        {
            return Container.Resolve<TComponent>();
        }
    }
}
