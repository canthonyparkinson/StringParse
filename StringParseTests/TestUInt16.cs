using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestUInt16 : TestIntegerType<UInt16>
    {
        protected override string GoodInput => "123";

        protected override UInt16 GoodResult => 123;

        protected override string BigInput => "45678";

        protected override UInt16 BigResult => 45678;

        protected override string TooBigInput => "98765";

        protected override string TooSmallInput => "-1";

        protected override UInt16? doConvert()
        {
            return inpt.ParseUInt16();
        }
    }
}
