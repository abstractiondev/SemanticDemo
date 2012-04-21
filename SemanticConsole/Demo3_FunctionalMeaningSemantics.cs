using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticConsole
{
    class Demo3_FunctionalMeaningSemantics
    {
        DateTime AddYearToParameter(DateTime dateTime)
        {
            dateTime = dateTime.AddYears(1);
            return dateTime;
        }
    }
}
