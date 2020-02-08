using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ca.canthonyparkinson.StringParse;

namespace StringParseTests
{
    [TestClass]
    public class TestSingle : TestFloatType<Single>
    {
        protected override string GoodInput => "3E7";

        protected override float GoodResult => 30000000F;

        protected override string DecimalInput => "0.000005";

        protected override float DecimalResult => 5e-6F;

        protected override string BigInput => "1.234567890123456789";

        protected override float BigResult => 1.234567F;

        protected override string TooBigInput => "1E99";

        protected override string TooSmallInput => "-1E99";

        protected override bool ApproximatelyEqual(float p1, float p2)
        {
            return Math.Abs(p1 - p2) < 1E-6;
        }

        protected override float? doConvert()
        {
            return inpt.ParseSingle();
        }
    }
}
