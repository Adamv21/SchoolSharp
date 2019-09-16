using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSharp.Common.Extensions
{
    public static class IDictionaryExtensions
    {
        public static void AddOrReplace<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, TValue value)
        {
            if (source.ContainsKey(key))
                source[key] = value;
            else
                source.Add(key, value);
        }

        public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key)
        {
            if (!source.TryGetValue(key, out var value))
                value = default(TValue);
            return value;
        }
    }
}
