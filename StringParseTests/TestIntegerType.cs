using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringParseTests
{
    [TestClass]
    public abstract class TestIntegerType<T> where T : struct
    {
        protected String inpt;
        protected T? rslt;

        protected abstract T? doConvert();
        protected abstract String GoodInput { get; }
        protected abstract T GoodResult { get; }
        protected abstract String BigInput { get; }
        protected abstract T BigResult { get; }
        protected abstract String TooBigInput { get; }
        protected abstract String TooSmallInput { get; }

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
