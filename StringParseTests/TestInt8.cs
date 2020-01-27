using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestInt8 : TestIntegerType<SByte>
    {
        protected override string GoodInput => "123";

        protected override SByte GoodResult => 123;

        protected override string BigInput => "127";

        protected override SByte BigResult => 127;
        protected override string TooBigInput => "200";

        protected override string TooSmallInput => "-200";

        protected override SByte? doConvert()
        {
            return inpt.ParseInt8();
        }
    }
}
