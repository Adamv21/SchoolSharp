using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Common.Builders
{
    public abstract class BaseBuilder<TResult>
    {
        public abstract TResult Build();
    }
}
