using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;
using System.Globalization;

namespace StringParseTests
{
    [TestClass]
    public class TestDateTime
    {
        private static CultureInfo enUS = new CultureInfo("en-US");

        [TestMethod]
        public void TestValid1()
        {
            AssertValid(DateTime.TryParse("2020/03/28 23:43:53"), new DateTime(2020,3,28,23,43,53));
            AssertValid(DateTime.TryParse("03/28/2020 23:43:53"), new DateTime(2020, 3, 28, 23, 43, 53));
            AssertValid(DateTime.TryParse("2020/03/28"), new DateTime(2020, 3, 28));
        }
        [TestMethod]
        public void TestValid3()
        {
            AssertValid(DateTime.TryParse("03/28/2020 23:43:53", enUS, DateTimeStyles.None), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Unspecified);
            AssertValid(DateTime.TryParse("03/28/2020 23:43:53", enUS, DateTimeStyles.AssumeLocal), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Local);
            AssertValid(DateTime.TryParse("03/28/2020 23:43:53 -05:00", enUS, DateTimeStyles.AdjustToUniversal), new DateTime(2020, 3, 29, 4, 43, 53), DateTimeKind.Utc);
        }
        [TestMethod]
        public void TestValidExactSingle()
        {
            AssertValid(DateTime.TryParseExact("03/28/2020 23:43:53", "MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Unspecified);
            AssertValid(DateTime.TryParseExact("03/28/2020 23:43:53", "MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.AssumeLocal), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Local);
            AssertValid(DateTime.TryParseExact("03/28/2020 23:43:53 -05:00", "MM/dd/yyyy HH:mm:ss zzz", enUS, DateTimeStyles.AdjustToUniversal), new DateTime(2020, 3, 29, 4, 43, 53), DateTimeKind.Utc);
        }
        [TestMethod]
        public void TestValidExactArray()
        {
            AssertValid(DateTime.TryParseExact("03/28/2020 23:43:53", new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Unspecified);
            AssertValid(DateTime.TryParseExact("03/28/2020 23:43:53", new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.AssumeLocal), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Local);
            AssertValid(DateTime.TryParseExact("03/28/2020 23:43:53 -05:00", new string[] { "MM/dd/yyyy HH:mm:ss zzz" }, enUS, DateTimeStyles.AdjustToUniversal), new DateTime(2020, 3, 29, 4, 43, 53), DateTimeKind.Utc);
        }
        [TestMethod]
        public void TestInvalid1()
        {
            Assert.IsFalse(DateTime.TryParse("").HasValue);
            String? s = null;
            Assert.IsFalse(DateTime.TryParse(s).HasValue);
            Assert.IsFalse(DateTime.TryParse("today").HasValue);
        }
        [TestMethod]
        public void TestInvalid3()
        {
            Assert.IsFalse(DateTime.TryParse("", enUS, DateTimeStyles.None).HasValue);
            String? s = null;
            Assert.IsFalse(DateTime.TryParse(s, enUS, DateTimeStyles.None).HasValue);
            Assert.IsFalse(DateTime.TryParse("today", enUS, DateTimeStyles.None).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactSingle()
        {
            Assert.IsFalse(DateTime.TryParseExact("", "MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None).HasValue);
            String? s = null;
            Assert.IsFalse(DateTime.TryParseExact(s, "MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None).HasValue);
            Assert.IsFalse(DateTime.TryParseExact("today", "MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactArray()
        {
            Assert.IsFalse(DateTime.TryParseExact("", new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None).HasValue);
            String? s = null;
            Assert.IsFalse(DateTime.TryParseExact(s, new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None).HasValue);
            Assert.IsFalse(DateTime.TryParseExact("today", new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None).HasValue);
        }

        private void AssertValid(DateTime? rslt, DateTime expected)
        {
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expected, rslt.Value);
        }

        private void AssertValid(DateTime? rslt, DateTime expected, DateTimeKind expectedKind)
        {
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expected, rslt.Value);
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(expectedKind, rslt.Value.Kind);
        }

    }
}
