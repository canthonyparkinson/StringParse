using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestBoolean
    {
        [TestMethod]
        public void TestValid()
        {
            AssertValid(Boolean.TryParse("True"), true);
            AssertValid(Boolean.TryParse("False"), false);
            AssertValid(Boolean.TryParse("TRUE"), true);
            AssertValid(Boolean.TryParse("FALSE"), false);
            AssertValid(Boolean.TryParse("true"), true);
            AssertValid(Boolean.TryParse("false"), false);
            AssertValid(Boolean.TryParse("Yes"), true);
            AssertValid(Boolean.TryParse("No"), false);
            AssertValid(Boolean.TryParse("YES"), true);
            AssertValid(Boolean.TryParse("NO"), false);
            AssertValid(Boolean.TryParse("yes"), true);
            AssertValid(Boolean.TryParse("no"), false);
            AssertValid(Boolean.TryParse("T"), true);
            AssertValid(Boolean.TryParse("F"), false);
            AssertValid(Boolean.TryParse("t"), true);
            AssertValid(Boolean.TryParse("f"), false);
            AssertValid(Boolean.TryParse("Y"), true);
            AssertValid(Boolean.TryParse("N"), false);
            AssertValid(Boolean.TryParse("y"), true);
            AssertValid(Boolean.TryParse("n"), false);
            AssertValid(Boolean.TryParse("1"), true);
            AssertValid(Boolean.TryParse("0"), false);
        }

        private void AssertValid(Boolean? rslt, bool expected)
        {
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expected, rslt.Value);
        }

        [TestMethod]
        public void TestInvalid()
        {
            Assert.IsFalse(Boolean.TryParse("").HasValue);
            Assert.IsFalse(Boolean.TryParse("Ye").HasValue);
            Assert.IsFalse(Boolean.TryParse("9").HasValue);
            String? s = null;
            Assert.IsFalse(Boolean.TryParse(s).HasValue);

        }

        [TestMethod]   
        public void TestSpan()
        {
            AssertValid(Boolean.TryParse(" Yes ".AsSpan()), true);
        }
    }
}
