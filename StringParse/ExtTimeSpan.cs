using System;
using System.Globalization;

//namespace System.Runtime.CompilerServices
//{
//    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
//         | AttributeTargets.Method)]
//    public sealed class ExtensionAttribute : Attribute { }
//}
namespace ca.canthonyparkinson.StringParse
{
    public static class ExtTimeSpan
    {
        extension(TimeSpan)
        {
            public static TimeSpan? TryParse(String str) => (TimeSpan.TryParse(str, out TimeSpan val) ? new TimeSpan?(val) : null);
            public static TimeSpan? TryParse(String str, IFormatProvider provider) => (TimeSpan.TryParse(str, provider, out TimeSpan val) ? new TimeSpan?(val) : null);
            public static TimeSpan? TryParseExact(String str, string format, IFormatProvider provider) => (TimeSpan.TryParseExact(str, format, provider, out TimeSpan val) ? new TimeSpan?(val) : null);
            public static TimeSpan? TryParseExact(String str, string[] formats, IFormatProvider provider) => (TimeSpan.TryParseExact(str, formats, provider, out TimeSpan val) ? new TimeSpan?(val) : null);
            public static TimeSpan? TryParseExact(String str, string format, IFormatProvider provider, TimeSpanStyles style) => (TimeSpan.TryParseExact(str, format, provider, style, out TimeSpan val) ? new TimeSpan?(val) : null);
            public static TimeSpan? TryParseExact(String str, string[] formats, IFormatProvider provider, TimeSpanStyles style) => (TimeSpan.TryParseExact(str, formats, provider, style, out TimeSpan val) ? new TimeSpan?(val) : null);
        }
    }
}
