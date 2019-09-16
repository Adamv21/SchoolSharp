using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Abstractions.Registrators
{
    public interface IComponentRegistrator
    {
        void Register(ContainerBuilder builder);
    }

}
