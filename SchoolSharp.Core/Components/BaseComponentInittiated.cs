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
            source.GuardNotNull(nameof(source));
            metadata.GuardNotNull(nameof(metadata));
            this.Source = source;
            this.Metadata = metadata;
        }

        public IClientComponent Source { get; }
        public IDictionary<string, object> Metadata { get; set; }
    }
}
