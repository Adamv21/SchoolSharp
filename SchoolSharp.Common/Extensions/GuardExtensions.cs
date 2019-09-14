using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Common.Extensions
{
    public static class GuardExtensions
    {
        public static void GuardNotNull(this object @object, string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (@object == null)
                throw new ArgumentNullException(name);


        }
    }
}
