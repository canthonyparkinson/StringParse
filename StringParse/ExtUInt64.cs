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
    public static class ExtUInt64
    {
        extension(UInt64)
        {
            public static UInt64? TryParse(String str) => (UInt64.TryParse(str, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(String str, NumberStyles style, IFormatProvider provider) => (UInt64.TryParse(str, style, provider, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(String str, IFormatProvider provider) => (UInt64.TryParse(str, provider, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(ReadOnlySpan<char> str) => (UInt64.TryParse(str, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (UInt64.TryParse(str, style, provider, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (UInt64.TryParse(str, provider, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(ReadOnlySpan<Byte> bytes) => (UInt64.TryParse(bytes, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (UInt64.TryParse(bytes, style, provider, out UInt64 val) ? new UInt64?(val) : null);
            public static UInt64? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (UInt64.TryParse(bytes, provider, out UInt64 val) ? new UInt64?(val) : null);
        }
    }
}
