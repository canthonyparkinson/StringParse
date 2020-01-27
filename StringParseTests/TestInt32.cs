using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestInt32 : TestIntegerType<Int32>
    {
        protected override string GoodInput => "123";

        protected override Int32 GoodResult => 123;

        protected override string BigInput => "123456789";

        protected override Int32 BigResult => 123456789;

        protected override string TooBigInput => "123456789012";

        protected override string TooSmallInput => "-123456789012";

        protected override Int32? doConvert()
        {
            return inpt.ParseInt32();
        }
    }
}
