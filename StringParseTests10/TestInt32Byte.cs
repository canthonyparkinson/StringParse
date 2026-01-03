using ca.canthonyparkinson.StringParse;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace StringParseTests
{
    [TestClass]
    public class TestInt32Byte : TestInt32
    {
        protected override Int32? doConvert()
        {
            return (inpt is null) ? null : Int32.TryParse(Encoding.UTF8.GetBytes(inpt).AsSpan());
        }
    }
}
