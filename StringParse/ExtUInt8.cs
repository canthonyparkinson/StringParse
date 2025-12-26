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
    public static class ExtUInt8
    {
        extension(Byte)
        {
            public static Byte? TryParse(String str) => (Byte.TryParse(str, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Byte.TryParse(str, style, provider, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(String str, IFormatProvider provider) => (Byte.TryParse(str, provider, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(ReadOnlySpan<char> str) => (Byte.TryParse(str, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Byte.TryParse(str, style, provider, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Byte.TryParse(str, provider, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(ReadOnlySpan<Byte> bytes) => (Byte.TryParse(bytes, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Byte.TryParse(bytes, style, provider, out Byte val) ? new Byte?(val) : null);
            public static Byte? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Byte.TryParse(bytes, provider, out Byte val) ? new Byte?(val) : null);
        }
    }
}
