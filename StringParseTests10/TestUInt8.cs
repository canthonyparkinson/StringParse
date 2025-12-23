using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestUInt8 : TestIntegerType<Byte>
    {
        protected override string GoodInput => "123";

        protected override Byte GoodResult => 123;

        protected override string BigInput => "200";

        protected override Byte BigResult => 200;

        protected override string TooBigInput => "275";

        protected override string TooSmallInput => "-1";

        [TestMethod]

        public void TestObsolete()
        {
            var x = "".ParseInt8();
        }

        protected override Byte? doConvert()
        {
            return Byte.TryParse(inpt);
        }
    }
}
