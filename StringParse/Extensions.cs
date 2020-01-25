using System;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
         | AttributeTargets.Method)]
    public sealed class ExtensionAttribute : Attribute { }
}
namespace ca.canthonyparkinson.StringParse
{
    public static class Extensions
    {
        public static int? ParseInt32(this String str) => (Int32.TryParse(str, out Int32 val) ? new int?(val) : null);
    }
}
