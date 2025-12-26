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
    public static class ExtSingle
    {
        extension(Single)
        {
            public static Single? TryParse(String str) => (Single.TryParse(str, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Single.TryParse(str, style, provider, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(String str, IFormatProvider provider) => (Single.TryParse(str, provider, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(ReadOnlySpan<char> str) => (Single.TryParse(str, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Single.TryParse(str, style, provider, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Single.TryParse(str, provider, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(ReadOnlySpan<Byte> bytes) => (Single.TryParse(bytes, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Single.TryParse(bytes, style, provider, out Single val) ? new Single?(val) : null);
            public static Single? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Single.TryParse(bytes, provider, out Single val) ? new Single?(val) : null);
        }
    }
}
