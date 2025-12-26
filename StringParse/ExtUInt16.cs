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
    public static class ExtUInt16
    {
        extension(UInt16)
        {
            public static UInt16? TryParse(String str) => (UInt16.TryParse(str, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(String str, NumberStyles style, IFormatProvider provider) => (UInt16.TryParse(str, style, provider, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(String str, IFormatProvider provider) => (UInt16.TryParse(str, provider, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(ReadOnlySpan<char> str) => (UInt16.TryParse(str, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (UInt16.TryParse(str, style, provider, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (UInt16.TryParse(str, provider, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(ReadOnlySpan<Byte> bytes) => (UInt16.TryParse(bytes, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (UInt16.TryParse(bytes, style, provider, out UInt16 val) ? new UInt16?(val) : null);
            public static UInt16? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (UInt16.TryParse(bytes, provider, out UInt16 val) ? new UInt16?(val) : null);
        }
    }
}
