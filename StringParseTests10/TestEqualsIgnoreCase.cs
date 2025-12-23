using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestEqualsIgnoreCase
    {
        [TestMethod]
        public void TestTrue()
        {
            Assert.IsTrue("".EqualsIgnoreCase(String.Empty));
            Assert.IsTrue(String.Empty.EqualsIgnoreCase(""));
            String? tst = null;
            Assert.IsTrue(tst.EqualsIgnoreCase(String.Empty));
            Assert.IsTrue("abc".EqualsIgnoreCase("ABC"));
        }

        [TestMethod]
        public void TestFalse()
        {
            Assert.IsFalse("xyz".EqualsIgnoreCase("ABC"));
        }
    }
}
