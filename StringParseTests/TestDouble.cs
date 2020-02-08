using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestDouble : TestFloatType<Double>
    {
        protected override string GoodInput => "3E7";

        protected override double GoodResult => 30000000;

        protected override string BigInput => "1.234567890123456789";

        protected override double BigResult => 1.23456789012346;

        protected override string TooBigInput => "1E999";

        protected override string TooSmallInput => "-1E999";

        protected override string DecimalInput => "0.000005";

        protected override double DecimalResult => 5e-6;

        protected override bool ApproximatelyEqual(double p1, double p2)
        {
            return Math.Abs(p1 - p2) < 1E-14;
        }

        protected override double? doConvert()
        {
            return inpt.ParseDouble();
        }
    }
}
