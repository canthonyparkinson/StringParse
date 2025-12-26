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
    public static class ExtInt16
        {
            extension(Int16)
            {
                public static Int16? TryParse(String str) => (Int16.TryParse(str, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Int16.TryParse(str, style, provider, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(String str, IFormatProvider provider) => (Int16.TryParse(str, provider, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(ReadOnlySpan<char> str) => (Int16.TryParse(str, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Int16.TryParse(str, style, provider, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Int16.TryParse(str, provider, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(ReadOnlySpan<Byte> bytes) => (Int16.TryParse(bytes, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Int16.TryParse(bytes, style, provider, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Int16.TryParse(bytes, provider, out Int16 val) ? new Int16?(val) : null);
            }
        }
}
