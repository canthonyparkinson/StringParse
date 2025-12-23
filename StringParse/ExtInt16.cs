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
    public static class ExtInt16
        {
            extension(Int16)
            {
                public static Int16? TryParse(String str) => (Int16.TryParse(str, out Int16 val) ? new Int16?(val) : null);
                public static Int16? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Int16.TryParse(str, style, provider, out Int16 val) ? new Int16?(val) : null);
            }
        }
}
