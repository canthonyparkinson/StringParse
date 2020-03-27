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
            AssertValid("True".ParseBoolean(), true);
            AssertValid("False".ParseBoolean(), false);
            AssertValid("TRUE".ParseBoolean(), true);
            AssertValid("FALSE".ParseBoolean(), false);
            AssertValid("true".ParseBoolean(), true);
            AssertValid("false".ParseBoolean(), false);
            AssertValid("Yes".ParseBoolean(), true);
            AssertValid("No".ParseBoolean(), false);
            AssertValid("YES".ParseBoolean(), true);
            AssertValid("NO".ParseBoolean(), false);
            AssertValid("yes".ParseBoolean(), true);
            AssertValid("no".ParseBoolean(), false);
            AssertValid("T".ParseBoolean(), true);
            AssertValid("F".ParseBoolean(), false);
            AssertValid("t".ParseBoolean(), true);
            AssertValid("f".ParseBoolean(), false);
            AssertValid("Y".ParseBoolean(), true);
            AssertValid("N".ParseBoolean(), false);
            AssertValid("y".ParseBoolean(), true);
            AssertValid("n".ParseBoolean(), false);
            AssertValid("1".ParseBoolean(), true);
            AssertValid("0".ParseBoolean(), false);
        }

        private void AssertValid(Boolean? rslt, bool expected)
        {
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expected, rslt.Value);
        }

        [TestMethod]
        public void TestInvalid()
        {
            Assert.IsFalse("".ParseBoolean().HasValue);
            Assert.IsFalse("Ye".ParseBoolean().HasValue);
            Assert.IsFalse("9".ParseBoolean().HasValue);
            String s = null;
            Assert.IsFalse(s.ParseBoolean().HasValue);
        }
    }
}
