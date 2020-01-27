using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestUInt64 : TestIntegerType<UInt64>
    {
        protected override string GoodInput => "123";

        protected override UInt64 GoodResult => 123;

        protected override string BigInput => $"{((UInt64)(Int64.MaxValue) + 1)}";

        protected override UInt64 BigResult => ((UInt64)(Int64.MaxValue) + 1);

        protected override string TooBigInput => "123456789012345678900";

        protected override string TooSmallInput => "-1";

        protected override UInt64? doConvert()
        {
            return inpt.ParseUInt64();
        }
    }
}
