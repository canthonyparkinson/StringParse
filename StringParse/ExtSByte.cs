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
    public static class ExtSByte
        {
            extension(SByte)
            {
                public static SByte? TryParse(String str) => (SByte.TryParse(str, out SByte val) ? new SByte?(val) : null);
                public static SByte? TryParse(String str, NumberStyles style, IFormatProvider provider) => (SByte.TryParse(str, style, provider, out SByte val) ? new SByte?(val) : null);
            }
        }
}
