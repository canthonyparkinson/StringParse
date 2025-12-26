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
    public static class ExtDouble
    {
        extension(Double)
        {
            public static Double? TryParse(String str) => (Double.TryParse(str, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Double.TryParse(str, style, provider, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(String str, IFormatProvider provider) => (Double.TryParse(str, provider, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(ReadOnlySpan<char> str) => (Double.TryParse(str, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Double.TryParse(str, style, provider, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Double.TryParse(str, provider, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(ReadOnlySpan<Byte> bytes) => (Double.TryParse(bytes, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Double.TryParse(bytes, style, provider, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Double.TryParse(bytes, provider, out Double val) ? new Double?(val) : null);
        }
    }
}
