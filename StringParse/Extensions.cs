using System;
using System.Globalization;
using System.Numerics;

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
        public static SByte? ParseInt8(this String str) => (SByte.TryParse(str, out SByte val) ? new SByte?(val) : null);
        public static SByte? ParseInt8(this String str, NumberStyles style, IFormatProvider provider) => (SByte.TryParse(str, style, provider, out SByte val) ? new SByte?(val) : null);

        public static Int16? ParseInt16(this String str) => (Int16.TryParse(str, out Int16 val) ? new Int16?(val) : null);
        public static Int16? ParseInt16(this String str, NumberStyles style, IFormatProvider provider) => (Int16.TryParse(str, style, provider, out Int16 val) ? new Int16?(val) : null);

        public static Int32? ParseInt32(this String str) => (Int32.TryParse(str, out Int32 val) ? new Int32?(val) : null);
        public static Int32? ParseInt32(this String str, NumberStyles style, IFormatProvider provider) => (Int32.TryParse(str, style, provider, out Int32 val) ? new Int32?(val) : null);

        public static Int64? ParseInt64(this String str) => (Int64.TryParse(str, out Int64 val) ? new Int64?(val) : null);
        public static Int64? ParseInt64(this String str, NumberStyles style, IFormatProvider provider) => (Int64.TryParse(str, style, provider, out Int64 val) ? new Int64?(val) : null);

        public static Byte? ParseUInt8(this String str) => (Byte.TryParse(str, out Byte val) ? new Byte?(val) : null);
        public static Byte? ParseUInt8(this String str, NumberStyles style, IFormatProvider provider) => (Byte.TryParse(str, style, provider, out Byte val) ? new Byte?(val) : null);

        public static UInt16? ParseUInt16(this String str) => (UInt16.TryParse(str, out UInt16 val) ? new UInt16?(val) : null);
        public static UInt16? ParseUInt16(this String str, NumberStyles style, IFormatProvider provider) => (UInt16.TryParse(str, style, provider, out UInt16 val) ? new UInt16?(val) : null);

        public static UInt32? ParseUInt32(this String str) => (UInt32.TryParse(str, out UInt32 val) ? new UInt32?(val) : null);
        public static UInt32? ParseUInt32(this String str, NumberStyles style, IFormatProvider provider) => (UInt32.TryParse(str, style, provider, out UInt32 val) ? new UInt32?(val) : null);

        public static UInt64? ParseUInt64(this String str) => (UInt64.TryParse(str, out UInt64 val) ? new UInt64?(val) : null);
        public static UInt64? ParseUInt64(this String str, NumberStyles style, IFormatProvider provider) => (UInt64.TryParse(str, style, provider, out UInt64 val) ? new UInt64?(val) : null);

        public static BigInteger? ParseBigInteger(this String str) => (BigInteger.TryParse(str, out BigInteger val) ? new BigInteger?(val) : null);
        public static BigInteger? ParseBigInteger(this String str, NumberStyles style, IFormatProvider provider) => (BigInteger.TryParse(str, style, provider, out BigInteger val) ? new BigInteger?(val) : null);

        public static Decimal? ParseDecimal(this String str) => (Decimal.TryParse(str, out Decimal val) ? new Decimal?(val) : null);
        public static Decimal? ParseDecimal(this String str, NumberStyles style, IFormatProvider provider) => (Decimal.TryParse(str, style, provider, out Decimal val) ? new Decimal?(val) : null);

        public static Double? ParseDouble(this String str) => (Double.TryParse(str, out Double val) ? new Double?(val) : null);
        public static Double? ParseDouble(this String str, NumberStyles style, IFormatProvider provider) => (Double.TryParse(str, style, provider, out Double val) ? new Double?(val) : null);

        public static Single? ParseSingle(this String str) => (Single.TryParse(str, out Single val) ? new Single?(val) : null);
        public static Single? ParseSingle(this String str, NumberStyles style, IFormatProvider provider) => (Single.TryParse(str, style, provider, out Single val) ? new Single?(val) : null);

        public static Boolean? ParseBoolean(this String str) => (Boolean.TryParse(str, out Boolean val) ? new Boolean?(val) : null);

        public static DateTime? ParseDateTime(this String str) => (DateTime.TryParse(str, out DateTime val) ? new DateTime?(val) : null);
        public static DateTime? ParseDateTime(this String str, IFormatProvider provider, DateTimeStyles style) => (DateTime.TryParse(str, provider, style, out DateTime val) ? new DateTime?(val) : null);
        public static DateTime? ParseDateTimeExact(this String str, string format, IFormatProvider provider, DateTimeStyles style) => (DateTime.TryParseExact(str, format, provider, style, out DateTime val) ? new DateTime?(val) : null);
        public static DateTime? ParseDateTimeExact(this String str, string[] formats, IFormatProvider provider, DateTimeStyles style) => (DateTime.TryParseExact(str, formats, provider, style, out DateTime val) ? new DateTime?(val) : null);

        public static TimeSpan? ParseTimeSpan(this String str) => (TimeSpan.TryParse(str, out TimeSpan val) ? new TimeSpan?(val) : null);
        public static TimeSpan? ParseTimeSpan(this String str, IFormatProvider provider) => (TimeSpan.TryParse(str, provider, out TimeSpan val) ? new TimeSpan?(val) : null);
        public static TimeSpan? ParseTimeSpanExact(this String str, string format, IFormatProvider provider) => (TimeSpan.TryParseExact(str, format, provider, out TimeSpan val) ? new TimeSpan?(val) : null);
        public static TimeSpan? ParseTimeSpanExact(this String str, string[] formats, IFormatProvider provider) => (TimeSpan.TryParseExact(str, formats, provider, out TimeSpan val) ? new TimeSpan?(val) : null);
        public static TimeSpan? ParseTimeSpanExact(this String str, string format, IFormatProvider provider, TimeSpanStyles style) => (TimeSpan.TryParseExact(str, format, provider, style, out TimeSpan val) ? new TimeSpan?(val) : null);
        public static TimeSpan? ParseTimeSpanExact(this String str, string[] formats, IFormatProvider provider, TimeSpanStyles style) => (TimeSpan.TryParseExact(str, formats, provider, style, out TimeSpan val) ? new TimeSpan?(val) : null);
    }
}
