using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Components
{
    public abstract class BaseComponentInittiated : IComponentInittiated
    {
        protected BaseComponentInittiated(IClientComponent source, IDictionary<string, object> metadata)
        {
            this.Source = source.GuardNotNull(nameof(source));
            this.Metadata = metadata.GuardNotNull(nameof(metadata));
        }

        public IClientComponent Source { get; }
        public IDictionary<string, object> Metadata { get; set; }
    }
}
