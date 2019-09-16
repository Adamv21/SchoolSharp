using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Common.Extensions
{
    public static class GuardExtensions
    {

        public static T GuardNotNull<T>(this T source, string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (source == null)
                throw new ArgumentNullException(name);

            GuardNotNull(source, name);
            return source;
        }
    }
}
