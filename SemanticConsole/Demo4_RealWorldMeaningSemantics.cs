using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticConsole
{
    class Demo4_RealWorldMeaningSemantics
    {
        DateTime GetNextBirthDayFromCurrent(DateTime currentBirthDay)
        {
            currentBirthDay = currentBirthDay.AddYears(1);
            return currentBirthDay;
        }
    }
}
