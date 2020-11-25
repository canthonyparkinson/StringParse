using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestNullOrWhiteSpace
    {
        [TestMethod]
        public void TestTrue()
        {
            Assert.AreEqual(true, "".IsNullOrWhiteSpace());
            Assert.AreEqual(true, String.Empty.IsNullOrWhiteSpace());
            String tst = null;
            Assert.AreEqual(true, tst.IsNullOrWhiteSpace());
            Assert.AreEqual(true, "   ".IsNullOrWhiteSpace());
        }

        [TestMethod]
        public void TestFalse()
        {
            Assert.AreEqual(false, "True".IsNullOrWhiteSpace());
        }
    }
}
