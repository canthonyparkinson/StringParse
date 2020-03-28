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
            AssertValid("2020/03/28 23:43:53".ParseDateTime(), new DateTime(2020,3,28,23,43,53));
            AssertValid("03/28/2020 23:43:53".ParseDateTime(), new DateTime(2020, 3, 28, 23, 43, 53));
            AssertValid("2020/03/28".ParseDateTime(), new DateTime(2020, 3, 28));
        }
        [TestMethod]
        public void TestValid3()
        {
            AssertValid("03/28/2020 23:43:53".ParseDateTime(enUS, DateTimeStyles.None), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Unspecified);
            AssertValid("03/28/2020 23:43:53".ParseDateTime(enUS, DateTimeStyles.AssumeLocal), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Local);
            AssertValid("03/28/2020 23:43:53 -05:00".ParseDateTime(enUS, DateTimeStyles.AdjustToUniversal), new DateTime(2020, 3, 29, 4, 43, 53), DateTimeKind.Utc);
        }
        [TestMethod]
        public void TestValidExactSingle()
        {
            AssertValid("03/28/2020 23:43:53".ParseDateTimeExact("MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Unspecified);
            AssertValid("03/28/2020 23:43:53".ParseDateTimeExact("MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.AssumeLocal), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Local);
            AssertValid("03/28/2020 23:43:53 -05:00".ParseDateTimeExact("MM/dd/yyyy HH:mm:ss zzz", enUS, DateTimeStyles.AdjustToUniversal), new DateTime(2020, 3, 29, 4, 43, 53), DateTimeKind.Utc);
        }
        [TestMethod]
        public void TestValidExactArray()
        {
            AssertValid("03/28/2020 23:43:53".ParseDateTimeExact(new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Unspecified);
            AssertValid("03/28/2020 23:43:53".ParseDateTimeExact(new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.AssumeLocal), new DateTime(2020, 3, 28, 23, 43, 53), DateTimeKind.Local);
            AssertValid("03/28/2020 23:43:53 -05:00".ParseDateTimeExact(new string[] { "MM/dd/yyyy HH:mm:ss zzz" }, enUS, DateTimeStyles.AdjustToUniversal), new DateTime(2020, 3, 29, 4, 43, 53), DateTimeKind.Utc);
        }
        [TestMethod]
        public void TestInvalid1()
        {
            Assert.IsFalse("".ParseDateTime().HasValue);
            String s = null;
            Assert.IsFalse(s.ParseDateTime().HasValue);
            Assert.IsFalse("today".ParseDateTime().HasValue);
        }
        [TestMethod]
        public void TestInvalid3()
        {
            Assert.IsFalse("".ParseDateTime(enUS, DateTimeStyles.None).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseDateTime(enUS, DateTimeStyles.None).HasValue);
            Assert.IsFalse("today".ParseDateTime(enUS, DateTimeStyles.None).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactSingle()
        {
            Assert.IsFalse("".ParseDateTimeExact("MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseDateTimeExact("MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None).HasValue);
            Assert.IsFalse("today".ParseDateTimeExact("MM/dd/yyyy HH:mm:ss", enUS, DateTimeStyles.None).HasValue);
        }
        [TestMethod]
        public void TestInvalidExactArray()
        {
            Assert.IsFalse("".ParseDateTimeExact(new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None).HasValue);
            String s = null;
            Assert.IsFalse(s.ParseDateTimeExact(new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None).HasValue);
            Assert.IsFalse("today".ParseDateTimeExact(new string[] { "MM/dd/yyyy HH:mm:ss" }, enUS, DateTimeStyles.None).HasValue);
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
