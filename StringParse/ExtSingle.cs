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
        }
    }
}
