using System;
using System.Globalization;

namespace ca.canthonyparkinson.StringParse
{
    public static class ExtUInt128
    {
        extension(UInt128)
        {
            public static UInt128? TryParse(String str) => (UInt128.TryParse(str, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(String str, NumberStyles style, IFormatProvider provider) => (UInt128.TryParse(str, style, provider, out UInt128 val) ? new UInt128?(val) : null);
        }
    }
}
