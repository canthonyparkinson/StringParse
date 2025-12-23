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
            AssertValid(TimeSpan.TryParse("23:43:53"), new TimeSpan(23, 43, 53));
            AssertValid(TimeSpan.TryParse("23:43:53.654"), new TimeSpan(0, 23, 43, 53, 654));
        }

        [TestMethod]
        public void TestValid2()
        {
            AssertValid(TimeSpan.TryParse("23:43:53", enUS), new TimeSpan(23, 43, 53));
            AssertValid(TimeSpan.TryParse("23:43:53.654", enUS), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactSingle3()
        {
            AssertValid(TimeSpan.TryParseExact("23:43:53", "g",enUS), new TimeSpan(23, 43, 53));
            AssertValid(TimeSpan.TryParseExact("23:43:53.654", "g", enUS), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactArray3()
        {
            AssertValid(TimeSpan.TryParseExact("23:43:53", new string[] { "g" }, enUS), new TimeSpan(23, 43, 53));
            AssertValid(TimeSpan.TryParseExact("23:43:53.654", new string[] { "g" }, enUS), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactSingle4()
        {
            AssertValid(TimeSpan.TryParseExact("23:43:53", "g", enUS, TimeSpanStyles.None), new TimeSpan(23, 43, 53));
            AssertValid(TimeSpan.TryParseExact("23:43:53.654", "g", enUS, TimeSpanStyles.None), new TimeSpan(0, 23, 43, 53, 654));
        }
        [TestMethod]
        public void TestValidExactArray4()
        {
            AssertValid(TimeSpan.TryParseExact("23:43:53", new string[] { "g" }, enUS, TimeSpanStyles.None), new TimeSpan(23, 43, 53));
            AssertValid(TimeSpan.TryParseExact("23:43:53.654", new string[] { "g" }, enUS, TimeSpanStyles.None), new TimeSpan(0, 23, 43, 53, 654));
        }

        [TestMethod]
        public void TestInvalid1()
        {
            Assert.IsFalse(TimeSpan.TryParse("").HasValue);
            String? s = null;
            Assert.IsFalse(TimeSpan.TryParse(s).HasValue);
            Assert.IsFalse(TimeSpan.TryParse("One Hour").HasValue);
        }

        [TestMethod]
        public void TestInvalid2()
        {
            Assert.IsFalse(TimeSpan.TryParse("", enUS).HasValue);
            String? s = null;
            Assert.IsFalse(TimeSpan.TryParse(s, enUS).HasValue);
            Assert.IsFalse(TimeSpan.TryParse("One Hour", enUS).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactSingle3()
        {
            Assert.IsFalse(TimeSpan.TryParseExact("", "g", enUS).HasValue);
            String?  s = null;
            Assert.IsFalse(TimeSpan.TryParseExact(s, "g", enUS).HasValue);
            Assert.IsFalse(TimeSpan.TryParseExact("One Hour", "g", enUS).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactArray3()
        {
            Assert.IsFalse(TimeSpan.TryParseExact("", new string[] { "g" }, enUS).HasValue);
            String? s = null;
            Assert.IsFalse(TimeSpan.TryParseExact(s, new string[] { "g" }, enUS).HasValue);
            Assert.IsFalse(TimeSpan.TryParseExact("One Hour", new string[] { "g" }, enUS).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactSingle4()
        {
            Assert.IsFalse(TimeSpan.TryParseExact("", "g", enUS, TimeSpanStyles.None).HasValue);
            String? s = null;
            Assert.IsFalse(TimeSpan.TryParseExact(s, "g", enUS, TimeSpanStyles.None).HasValue);
            Assert.IsFalse(TimeSpan.TryParseExact("One Hour", "g", enUS, TimeSpanStyles.None).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactArray4()
        {
            Assert.IsFalse(TimeSpan.TryParseExact("", new string[] { "g" }, enUS, TimeSpanStyles.None).HasValue);
            String? s = null;
            Assert.IsFalse(TimeSpan.TryParseExact(s, new string[] { "g" }, enUS, TimeSpanStyles.None).HasValue);
            Assert.IsFalse(TimeSpan.TryParseExact("One Hour", new string[] { "g" }, enUS, TimeSpanStyles.None).HasValue);
        }

        private void AssertValid(TimeSpan? rslt, TimeSpan expected)
        {
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expected, rslt.Value);
        }

    }
}
