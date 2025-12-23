using System;
using System.Globalization;
using System.Numerics;

//namespace System.Runtime.CompilerServices
//{
//    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
//         | AttributeTargets.Method)]
//    public sealed class ExtensionAttribute : Attribute { }
//}
namespace ca.canthonyparkinson.StringParse
{
    public static class ExtBigInteger
    {
        extension(BigInteger)
        {
            public static BigInteger? TryParse(String str) => (BigInteger.TryParse(str, out BigInteger val) ? new BigInteger?(val) : null);
            public static BigInteger? TryParse(String str, NumberStyles style, IFormatProvider provider) => (BigInteger.TryParse(str, style, provider, out BigInteger val) ? new BigInteger?(val) : null);
        }
    }
}
