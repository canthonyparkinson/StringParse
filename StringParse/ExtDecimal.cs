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
    public static class ExtDecimal
    {
        extension(Decimal)
        {
            public static Decimal? TryParse(String str) => (Decimal.TryParse(str, out Decimal val) ? new Decimal?(val) : null);
            public static Decimal? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Decimal.TryParse(str, style, provider, out Decimal val) ? new Decimal?(val) : null);
        }
    }
}
