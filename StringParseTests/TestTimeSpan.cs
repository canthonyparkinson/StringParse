using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;
using System.Globalization;

namespace StringParseTests
{
    [TestClass]
    public class TestTimeSpan
    {
        private static CultureInfo enUS = new CultureInfo("en-US");

        [TestMethod]
        public void TestValid1()
        {
            AssertValid("23:43:53".ParseTimeSpan(), new TimeSpan(23, 43, 53));
            AssertValid("23:43:53.654".ParseTimeSpan(), new TimeSpan(0, 23, 43, 53, 654));
        }

        [TestMethod]
        public void TestValid2()
        {
            AssertValid("23:43:53".ParseTimeSpan(enUS), new TimeSpan(23, 43, 53));
            AssertValid("23:43:53.654".ParseTimeSpan(enUS), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactSingle3()
        {
            AssertValid("23:43:53".ParseTimeSpanExact("g",enUS), new TimeSpan(23, 43, 53));
            AssertValid("23:43:53.654".ParseTimeSpanExact("g", enUS), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactArray3()
        {
            AssertValid("23:43:53".ParseTimeSpanExact(new string[] { "g" }, enUS), new TimeSpan(23, 43, 53));
            AssertValid("23:43:53.654".ParseTimeSpanExact(new string[] { "g" }, enUS), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactSingle4()
        {
            AssertValid("23:43:53".ParseTimeSpanExact("g", enUS, TimeSpanStyles.None), new TimeSpan(23, 43, 53));
            AssertValid("23:43:53.654".ParseTimeSpanExact("g", enUS, TimeSpanStyles.None), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactArray4()
        {
            AssertValid("23:43:53".ParseTimeSpanExact(new string[] { "g" }, enUS, TimeSpanStyles.None), new TimeSpan(23, 43, 53));
            AssertValid("23:43:53.654".ParseTimeSpanExact(new string[] { "g" }, enUS, TimeSpanStyles.None), new TimeSpan(0, 23, 43, 53, 654));
        }

        [TestMethod]
        public void TestInvalid1()
        {
            Assert.IsFalse("".ParseTimeSpan().HasValue);
            String s = null;
            Assert.IsFalse(s.ParseTimeSpan().HasValue);
            Assert.IsFalse("One Hour".ParseTimeSpan().HasValue);
        }

        [TestMethod]
        public void TestInvalid2()
        {
            Assert.IsFalse("".ParseTimeSpan(enUS).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseTimeSpan(enUS).HasValue);
            Assert.IsFalse("One Hour".ParseTimeSpan(enUS).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactSingle3()
        {
            Assert.IsFalse("".ParseTimeSpanExact("g", enUS).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseTimeSpanExact("g", enUS).HasValue);
            Assert.IsFalse("One Hour".ParseTimeSpanExact("g", enUS).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactArray3()
        {
            Assert.IsFalse("".ParseTimeSpanExact(new string[] { "g" }, enUS).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseTimeSpanExact(new string[] { "g" }, enUS).HasValue);
            Assert.IsFalse("One Hour".ParseTimeSpanExact(new string[] { "g" }, enUS).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactSingle4()
        {
            Assert.IsFalse("".ParseTimeSpanExact("g", enUS, TimeSpanStyles.None).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseTimeSpanExact("g", enUS, TimeSpanStyles.None).HasValue);
            Assert.IsFalse("One Hour".ParseTimeSpanExact("g", enUS, TimeSpanStyles.None).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactArray4()
        {
            Assert.IsFalse("".ParseTimeSpanExact(new string[] { "g" }, enUS, TimeSpanStyles.None).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseTimeSpanExact(new string[] { "g" }, enUS, TimeSpanStyles.None).HasValue);
            Assert.IsFalse("One Hour".ParseTimeSpanExact(new string[] { "g" }, enUS, TimeSpanStyles.None).HasValue);
        }

        private void AssertValid(TimeSpan? rslt, TimeSpan expected)
        {
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expected, rslt.Value);
        }

    }
}
