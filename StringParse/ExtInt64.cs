using System;
using System.Data.SqlTypes;
using System.Globalization;

//namespace System.Runtime.CompilerServices
//{
//    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
//         | AttributeTargets.Method)]
//    public sealed class ExtensionAttribute : Attribute { }
//}
namespace ca.canthonyparkinson.StringParse
{
    public static class ExtInt64
    {
        extension(Int64)
        {
            public static Int64? TryParse(String str) => (Int64.TryParse(str, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Int64.TryParse(str, style, provider, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(String str, IFormatProvider provider) => (Int64.TryParse(str, provider, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(ReadOnlySpan<char> str) => (Int64.TryParse(str, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Int64.TryParse(str, style, provider, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Int64.TryParse(str, provider, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(ReadOnlySpan<Byte> bytes) => (Int64.TryParse(bytes, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Int64.TryParse(bytes, style, provider, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Int64.TryParse(bytes, provider, out Int64 val) ? new Int64?(val) : null);
        }
    }
}
