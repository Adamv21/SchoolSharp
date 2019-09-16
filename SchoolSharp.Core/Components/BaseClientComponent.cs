using SchoolSharp.Abstractions;
using SchoolSharp.Abstractions.Components;
using SchoolSharp.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Core.Components
{
    public abstract class BaseClientComponent : IClientComponent 
    {
        protected BaseClientComponent()
        {
        }


        public abstract string Name { get; }
    }
}
