using Autofac;
using SchoolSharp.Abstractions.Registrators;
using SchoolSharp.Common.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Registrators
{
    public class InstanceComponentRegistrator<TResult> : IComponentRegistrator where TResult : class
    {
        private readonly Func<TResult> func;
        public InstanceComponentRegistrator(Func<TResult> func)
        {
            this.func = func;
        }

        public InstanceComponentRegistrator(BaseBuilder<TResult> builder) : this(() => builder.Build())
        {

        }

        public void Register(ContainerBuilder builder)
        {
            var result = func();
            builder.RegisterInstance<TResult>(result);
        }
    }
}
