using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestInt16 : TestIntegerType<Int16>
    {
        protected override string GoodInput => "123";

        protected override Int16 GoodResult => 123;

        protected override string BigInput => "32767";

        protected override Int16 BigResult => 32767;
        protected override string TooBigInput => "98765";

        protected override string TooSmallInput => "-98765";

        protected override Int16? doConvert()
        {
            return inpt.ParseInt16();
        }
    }
}
