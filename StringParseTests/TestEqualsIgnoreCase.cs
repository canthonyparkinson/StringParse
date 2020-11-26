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
            Assert.AreEqual(true, "".EqualsIgnoreCase(String.Empty));
            Assert.AreEqual(true, String.Empty.EqualsIgnoreCase(""));
            String tst = null;
            Assert.AreEqual(true, tst.EqualsIgnoreCase(String.Empty));
            Assert.AreEqual(true, "abc".EqualsIgnoreCase("ABC"));
        }

        [TestMethod]
        public void TestFalse()
        {
            Assert.AreEqual(false, "xyz".EqualsIgnoreCase("ABC"));
        }
    }
}
