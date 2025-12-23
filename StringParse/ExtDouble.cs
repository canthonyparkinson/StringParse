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
    public static class ExtDouble
    {
        extension(Double)
        {
            public static Double? TryParse(String str) => (Double.TryParse(str, out Double val) ? new Double?(val) : null);
            public static Double? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Double.TryParse(str, style, provider, out Double val) ? new Double?(val) : null);
        }
    }
}
