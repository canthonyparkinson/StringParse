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
    public static class ExtDecimal
    {
        extension(Decimal)
        {
            public static Decimal? TryParse(String str) => (Decimal.TryParse(str, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Decimal.TryParse(str, style, provider, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(String str, IFormatProvider provider) => (Decimal.TryParse(str, provider, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(ReadOnlySpan<char> str) => (Decimal.TryParse(str, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Decimal.TryParse(str, style, provider, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Decimal.TryParse(str, provider, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(ReadOnlySpan<Byte> bytes) => (Decimal.TryParse(bytes, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Decimal.TryParse(bytes, style, provider, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Decimal.TryParse(bytes, provider, out Decimal val) ? new Decimal?(val) : null);
        }
    }
}
