using Autofac;
using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Registrators;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SchoolSharp.Core.Registrators
{

    public class AssemblyComponentRegistrator : IComponentRegistrator
    {
        private readonly Assembly assembly;


        public AssemblyComponentRegistrator(Assembly assembly)
        {
            assembly.GuardNotNull(nameof(assembly));
            this.assembly = assembly;
        }

        public void Register(ContainerBuilder builder)
        {
            var components = assembly.GetTypes().Where(c => !c.IsAbstract && c.GetCustomAttribute<AutoRegisterComponent>() != null);
            foreach(var component in components)
            {
                var attribute = component.GetCustomAttribute<AutoRegisterComponent>();

                builder.RegisterType(component).As(attribute.InterfaceType).SingleInstance();

            }
        }
    }
}
