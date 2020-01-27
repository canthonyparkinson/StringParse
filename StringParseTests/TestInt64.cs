using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestInt64 : TestIntegerType<Int64>
    {
        protected override string GoodInput => "123";

        protected override Int64 GoodResult => 123;

        protected override string BigInput => "123456789012345";

        protected override Int64 BigResult => 123456789012345;
        protected override string TooBigInput => "12345678901234567890";

        protected override string TooSmallInput => "-12345678901234567890";

        protected override Int64? doConvert()
        {
            return inpt.ParseInt64();
        }
    }
}
