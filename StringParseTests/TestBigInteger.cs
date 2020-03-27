using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestBigInteger
    {
        protected String inpt;
        protected BigInteger? rslt;

        protected BigInteger? doConvert() {
            return inpt.ParseBigInteger();
        }

        protected String GoodInput { get; } = "22475995960490625424077073372689854726603265";
        protected BigInteger GoodResult { get; } = new BigInteger(new byte[] {1,2,3,4,5,6,7,8,9,0,9,8,7,6,5,4,3,2,1 });
        protected String BigInput { get; } = "4182124603186232288019951419063998338566951506388321521084603009502717653070877519963657419560638618742465558199710107385597218895808163634444867200422558054418997100045926467305985";
        protected BigInteger BigResult { get; } = new BigInteger(new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1,
                                                                              1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1,
                                                                              1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1,
                                                                              1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1
                                                        });
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
            Assert.IsFalse(rslt.HasValue);
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
    }
}
