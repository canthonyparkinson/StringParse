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
    public static class ExtInt64
    {
        extension(Int64)
        {
            public static Int64? TryParse(String str) => (Int64.TryParse(str, out Int64 val) ? new Int64?(val) : null);
            public static Int64? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Int64.TryParse(str, style, provider, out Int64 val) ? new Int64?(val) : null);
        }
    }
}
