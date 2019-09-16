using Autofac;
using SchoolSharp.Abstractions.Registrators;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Registrators
{
    public class RegisterComponent : IComponentRegistrator
    {
        private readonly Type[] types;
        public RegisterComponent(params Type[] types)
        {
            this.types = types;

        }
        public void Register(ContainerBuilder builder)
        {
            foreach (var type in types)
                builder.RegisterType(type).SingleInstance();
        }
    }
}
