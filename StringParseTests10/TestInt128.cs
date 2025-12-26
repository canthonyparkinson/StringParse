using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestInt128 : TestIntegerType<Int128>
    {
        protected override string GoodInput => "123";

        protected override Int128 GoodResult => 123;

        protected override string BigInput => "123456789012345000000000000000";

        protected override Int128 BigResult => (Int128)123456789012345L * (Int128)1000000000000000L;

        protected override string TooBigInput => "123456789012345123456789012345000001234567890";

        protected override string TooSmallInput => "-123456789012345123456789012345000001234567890";

        protected override Int128? doConvert()
        {
            return Int128.TryParse(inpt);
        }
    }
}
