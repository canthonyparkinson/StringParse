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
    public static class ExtInt32
    {
        extension(Int32)
        {
            public static Int32? TryParse(String str) => (Int32.TryParse(str, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Int32.TryParse(str, style, provider, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(String str, IFormatProvider provider) => (Int32.TryParse(str, provider, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(ReadOnlySpan<char> str) => (Int32.TryParse(str, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Int32.TryParse(str, style, provider, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Int32.TryParse(str, provider, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(ReadOnlySpan<Byte> bytes) => (Int32.TryParse(bytes, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Int32.TryParse(bytes, style, provider, out Int32 val) ? new Int32?(val) : null);
            public static Int32? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Int32.TryParse(bytes, provider, out Int32 val) ? new Int32?(val) : null);
        }
    }
}
