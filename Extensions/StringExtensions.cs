using System;

namespace ForthDemo_v1.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsCaseSensitive(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }
    }
}
