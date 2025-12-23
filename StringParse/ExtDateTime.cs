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
    public static class ExtDateTime
    {
        extension(DateTime)
        {
            public static DateTime? TryParse(String str) => (DateTime.TryParse(str, out DateTime val) ? new DateTime?(val) : null);
            public static DateTime? TryParse(String str, IFormatProvider provider, DateTimeStyles style) => (DateTime.TryParse(str, provider, style, out DateTime val) ? new DateTime?(val) : null);
            public static DateTime? TryParseExact(String str, string format, IFormatProvider provider, DateTimeStyles style) => (DateTime.TryParseExact(str, format, provider, style, out DateTime val) ? new DateTime?(val) : null);
            public static DateTime? TryParseExact(String str, string[] formats, IFormatProvider provider, DateTimeStyles style) => (DateTime.TryParseExact(str, formats, provider, style, out DateTime val) ? new DateTime?(val) : null);
        }
    }
}
