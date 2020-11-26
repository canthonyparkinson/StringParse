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

        [TestMethod]
        public void TestEmpty()
        {
            Assert.AreNotEqual(String.Empty, "True".EmptyIfNullOrWhiteSpace());
            Assert.AreEqual(String.Empty, "   ".EmptyIfNullOrWhiteSpace());
            Assert.AreEqual(String.Empty, "".EmptyIfNullOrWhiteSpace());
            String tst = null;
            Assert.AreEqual(String.Empty, tst.EmptyIfNullOrWhiteSpace());
        }
        [TestMethod]
        public void TestNotEmpty()
        {
            Assert.AreEqual("True", "True".EmptyIfNullOrWhiteSpace());
            Assert.AreNotEqual("   ", "   ".EmptyIfNullOrWhiteSpace());
        }
    }
}
