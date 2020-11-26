using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestNullOrEmpty
    {
        [TestMethod]
        public void TestTrue()
        {
            Assert.AreEqual(true, "".IsNullOrEmpty());
            Assert.AreEqual(true, String.Empty.IsNullOrEmpty());
            String tst = null;
            Assert.AreEqual(true, tst.IsNullOrEmpty());
        }

        [TestMethod]
        public void TestFalse()
        {
            Assert.AreEqual(false, "True".IsNullOrEmpty());
            Assert.AreEqual(false, "   ".IsNullOrEmpty());
        }

        [TestMethod]
        public void TestEmpty()
        {
            Assert.AreNotEqual(String.Empty, "True".EmptyIfNullOrEmpty());
            Assert.AreNotEqual(String.Empty, "   ".EmptyIfNullOrEmpty());
            Assert.AreEqual(String.Empty, "".EmptyIfNullOrEmpty());
            String tst = null;
            Assert.AreEqual(String.Empty, tst.EmptyIfNullOrEmpty());
        }
        [TestMethod]
        public void TestNotEmpty()
        {
            Assert.AreEqual("True", "True".EmptyIfNullOrEmpty());
            Assert.AreEqual("   ", "   ".EmptyIfNullOrEmpty());
        }
    }
}
