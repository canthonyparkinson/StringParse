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

            public static Boolean? TryParse(ReadOnlySpan<char> originalVaue)
            {
                ReadOnlySpan<char> value = strip(originalVaue);
                if (value.Length < 1) return null;

                switch (Char.ToLower(value[0])) {
                    case 't':
                        if (value.Length == 1) return true;
                        return checkTrue(value);
                    case 'f':
                        if (value.Length == 1) return false;
                        return checkFalse(value);
                    case 'y':
                        if (value.Length == 1) return true;
                        return checkYes(value);
                    case 'n':
                        if (value.Length == 1) return false;
                        return checkNo(value);
                    case '1':
                        if (value.Length == 1) return true;
                        return null;
                    case '0':
                        if (value.Length == 1) return false;
                        return null;
                }
                return null;
            }

            public static Boolean? TryParse(String str)
            {
                if (String.IsNullOrWhiteSpace(str))
                    return null;

                return TryParse(str.AsSpan());
            }
        }

        private static Boolean? checkTrue(ReadOnlySpan<char> value)
        {
            if (value.Length != 4) return null;
            if (Char.ToLower(value[1]) != 'r') return null;
            if (Char.ToLower(value[2]) != 'u') return null;
            if (Char.ToLower(value[3]) == 'e') return true;
            return null;
        }

        private static Boolean? checkFalse(ReadOnlySpan<char> value)
        {
            if (value.Length != 5) return null;
            if (Char.ToLower(value[1]) != 'a') return null;
            if (Char.ToLower(value[2]) != 'l') return null;
            if (Char.ToLower(value[3]) != 's') return null;
            if (Char.ToLower(value[4]) == 'e') return false;
            return null;
        }

        private static Boolean? checkYes(ReadOnlySpan<char> value)
        {
            if (value.Length != 3) return null;
            if (Char.ToLower(value[1]) != 'e') return null;
            if (Char.ToLower(value[2]) == 's') return true;
            return null;
        }

        private static Boolean? checkNo(ReadOnlySpan<char> value)
        {
            if (value.Length != 2) return null;
            if (Char.ToLower(value[1]) == 'o') return false;
            return null;
        }

        private static ReadOnlySpan<char> strip(ReadOnlySpan<char> value)
        {
            if (value.Length == 0) return value;
            int start = 0;
            int end = value.Length-1;
            int i = start;

            while (i < end) {
                if (Char.IsWhiteSpace(value[i]))
                {
                    i++;
                }
                else {
                    start = i;
                    break;
                }
            }

            i = end;
            while (i > start) {
                if (Char.IsWhiteSpace(value[i]))
                {
                    i--;
                }
                else
                {
                    end = i;
                    break;
                }
            }

            return value[start..(end + 1)];
        }
    }
}
