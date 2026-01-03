using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestInt32Char : TestInt32
    {
        protected override Int32? doConvert()
        {
            return Int32.TryParse(inpt.AsSpan());
        }
    }
}
