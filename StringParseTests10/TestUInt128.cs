using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestUInt128 : TestIntegerType<UInt128>
    {
        protected override string GoodInput => "123";

        protected override UInt128 GoodResult => 123;

        protected override string BigInput => "123456789012345000000000000000";

        protected override UInt128 BigResult => (UInt128)123456789012345L * (UInt128)1000000000000000L;

        protected override string TooBigInput => "12345678901234512345678901234500000";

        protected override string TooSmallInput => "-12345678901234512345678901234500000";

        protected override UInt128? doConvert()
        {
            return UInt128.TryParse(inpt);
        }
    }
}
