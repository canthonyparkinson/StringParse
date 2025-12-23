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
        }
    }
}
