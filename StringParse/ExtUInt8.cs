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
        }
    }
}
