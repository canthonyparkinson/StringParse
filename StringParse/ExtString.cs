using System;
using System.Collections.Generic;
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
        public static class ExtString
        {
            extension(String str)
            {
                public bool IsNullOrEmpty() => String.IsNullOrEmpty(str);
                public bool IsNullOrWhiteSpace() => String.IsNullOrWhiteSpace(str);
                public string EmptyIfNullOrEmpty() => (IsNullOrEmpty(str) ? String.Empty : str);
                public string EmptyIfNullOrWhiteSpace() => (IsNullOrWhiteSpace(str) ? String.Empty : str);
                public bool EqualsIgnoreCase(string other) => String.Compare(EmptyIfNullOrEmpty(str), EmptyIfNullOrEmpty(other), true) == 0;
        }
    }
}
