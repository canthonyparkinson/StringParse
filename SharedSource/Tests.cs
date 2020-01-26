using System;
using System.Collections.Generic;
using System.Text;
using ca.canthonyparkinson.StringParse;

namespace SharedSource
{
    public class Tests
    {
        public Boolean Run()
        {
            if (!TestIfNull())
                return false;

            if (!TestParseInt32())
                return false;

            return true;
        }

        public Boolean TestIfNull()
        {
            String inpt = null;
            String tst = inpt.IfNull(String.Empty);

            if (tst == null)
                return false;

            tst = inpt.IfNull();
            if (tst == null)
                return false;

            inpt = String.Empty;
            tst = inpt.IfNull("ABC");

            if (tst != String.Empty)
                return false;

            inpt = "ABC";
            tst = inpt.IfNull(String.Empty);

            if (tst != "ABC")
                return false;

            return true;
        }

        public Boolean TestParseInt32()
        {
            String inpt = null;
            if (inpt.ParseInt32().HasValue)
                return false;

            inpt = String.Empty;
            if (inpt.ParseInt32().HasValue)
                return false;

            inpt = "ABC";
            if (inpt.ParseInt32().HasValue)
                return false;

            inpt = "123";
            if (!(inpt.ParseInt32().HasValue))
                return false;
            if ((inpt.ParseInt32().Value) != 123)
                return false;

            inpt = "1.5";
            if (inpt.ParseInt32().HasValue)
                return false;

            return true;
        }
    }
}
