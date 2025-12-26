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
            public static UInt128? TryParse(String str, IFormatProvider provider) => (UInt128.TryParse(str, provider, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(ReadOnlySpan<char> str) => (UInt128.TryParse(str, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(ReadOnlySpan<char> str, NumberStyles style, IFormatProvider provider) => (UInt128.TryParse(str, style, provider, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(ReadOnlySpan<char> str, IFormatProvider provider) => (UInt128.TryParse(str, provider, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(ReadOnlySpan<Byte> bytes) => (UInt128.TryParse(bytes, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(ReadOnlySpan<Byte> bytes, NumberStyles style, IFormatProvider provider) => (UInt128.TryParse(bytes, style, provider, out UInt128 val) ? new UInt128?(val) : null);
            public static UInt128? TryParse(ReadOnlySpan<Byte> bytes, IFormatProvider provider) => (UInt128.TryParse(bytes, provider, out UInt128 val) ? new UInt128?(val) : null);
        }
    }
}
