using System;
using System.Globalization;

namespace ca.canthonyparkinson.StringParse
{
    public static class ExtInt128
    {
        extension(Int128)
        {
            public static Int128? TryParse(String str) => (Int128.TryParse(str, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(String str, NumberStyles style, IFormatProvider provider) => (Int128.TryParse(str, style, provider, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(String str, IFormatProvider provider) => (Int128.TryParse(str, provider, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(ReadOnlySpan<char> str) => (Int128.TryParse(str, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (Int128.TryParse(str, style, provider, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (Int128.TryParse(str, provider, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(ReadOnlySpan<Byte> bytes) => (Int128.TryParse(bytes, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (Int128.TryParse(bytes, style, provider, out Int128 val) ? new Int128?(val) : null);
            public static Int128? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (Int128.TryParse(bytes, provider, out Int128 val) ? new Int128?(val) : null);
        }
    }
}
