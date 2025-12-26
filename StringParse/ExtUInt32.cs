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
    public static class ExtUInt32
    {
        extension(UInt32)
        {
            public static UInt32? TryParse(String str) => (UInt32.TryParse(str, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(String str, NumberStyles style, IFormatProvider provider) => (UInt32.TryParse(str, style, provider, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(String str, IFormatProvider provider) => (UInt32.TryParse(str, provider, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(ReadOnlySpan<char> str) => (UInt32.TryParse(str, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (UInt32.TryParse(str, style, provider, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (UInt32.TryParse(str, provider, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(ReadOnlySpan<Byte> bytes) => (UInt32.TryParse(bytes, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (UInt32.TryParse(bytes, style, provider, out UInt32 val) ? new UInt32?(val) : null);
            public static UInt32? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (UInt32.TryParse(bytes, provider, out UInt32 val) ? new UInt32?(val) : null);
        }
    }
}
