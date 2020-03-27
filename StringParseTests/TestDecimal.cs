using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestDecimal
    {
        protected String inpt;
        protected Decimal? rslt;

        protected Decimal? doConvert()
        {
            return inpt.ParseDecimal();
        }

        protected String GoodInput { get; } = "1660206991020683953362";
        protected Decimal GoodResult { get; } = new Decimal(1234, 5678, 90, false, 0);
        protected String BigInput { get; } = "39614081247908796757769715711";
        protected Decimal BigResult { get; } = new Decimal(Int32.MaxValue, Int32.MaxValue, Int32.MaxValue, false, 0);
        protected Decimal DecimalResult { get; } = new Decimal(123.45);
        protected String TooBigInput { get; } = "792281625142643375935439503350";
        protected String TooSmallInput { get; } = "-792281625142643375935439503350";
        [TestMethod]
        public void TestBasicNull()
        {
            inpt = null;
            rslt = doConvert();
            Assert.IsFalse(rslt.HasValue);
        }

        [TestMethod]
        public void TestBasicEmpty()
        {
            inpt = String.Empty;
            rslt = doConvert();
            Assert.IsFalse(rslt.HasValue);
        }

        [TestMethod]
        public void TestBasicDecimals()
        {
            inpt = "123.45";
            rslt = doConvert();
            Assert.IsTrue(rslt.HasValue);
            Assert.IsTrue(ApproximatelyEqual(DecimalResult, rslt.Value));
        }

        [TestMethod]
        public void TestBasicGood()
        {
            inpt = GoodInput;
            rslt = doConvert();
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(GoodResult, rslt.Value);
        }

        [TestMethod]
        public void TestBasicBig()
        {
            inpt = BigInput;
            rslt = doConvert();
            Assert.IsTrue(rslt.HasValue);
            Assert.AreEqual(BigResult, rslt.Value);
        }

        [TestMethod]
        public void TestBasicTooBig()
        {
            inpt = TooBigInput;
            rslt = doConvert();
            Assert.IsFalse(rslt.HasValue);
        }

        [TestMethod]
        public void TestBasicTooSmall()
        {
            inpt = TooSmallInput;
            rslt = doConvert();
            Assert.IsFalse(rslt.HasValue);
        }

        protected bool ApproximatelyEqual(Decimal p1, Decimal p2)
        {
            return Math.Abs(p1 - p2) < new decimal(1E-14);
        }

    }
}

