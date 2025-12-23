using System;

//namespace System.Runtime.CompilerServices
//{
//    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class
//         | AttributeTargets.Method)]
//    public sealed class ExtensionAttribute : Attribute { }
//}
namespace ca.canthonyparkinson.StringParse
{
    public static class ExtBoolean
    {
        extension(Boolean)
        {
            public static Boolean? TryParse(String str)
            {
                if (String.IsNullOrWhiteSpace(str))
                    return null;

                if (str.ToLower().Equals("true"))
                    return true;

                if (str.ToLower().Equals("t"))
                    return true;

                if (str.ToLower().Equals("yes"))
                    return true;

                if (str.ToLower().Equals("y"))
                    return true;

                if (str.ToLower().Equals("1"))
                    return true;

                if (str.ToLower().Equals("false"))
                    return false;

                if (str.ToLower().Equals("f"))
                    return false;

                if (str.ToLower().Equals("no"))
                    return false;

                if (str.ToLower().Equals("n"))
                    return false;

                if (str.ToLower().Equals("0"))
                    return false;

                return null;
            }
        }
    }
}
