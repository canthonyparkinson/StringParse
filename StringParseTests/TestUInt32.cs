using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestUInt32 : TestIntegerType<UInt32>
    {
        protected override string GoodInput => "123";

        protected override UInt32 GoodResult => 123;

        protected override string BigInput => "3123456789";

        protected override UInt32 BigResult => 3123456789;

        protected override string TooBigInput => "123456789012";

        protected override string TooSmallInput => "-1";

        protected override UInt32? doConvert()
        {
            return inpt.ParseUInt32();
        }
    }
}
