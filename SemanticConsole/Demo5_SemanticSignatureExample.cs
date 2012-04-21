using System;

namespace SemanticConsole
{
    class Demo5_SemanticSignatureExample
    {
        /// <summary>
        /// Signature is composed of semantically strictly defined combination of following:
        /// 1. Parameters (semantically defined type(s) that includes the semantic meaning and data type)
        /// 2. Method name (unique within the domain's context)
        /// 3. Return value (semantically defined type that includes the semantic meaning and data type)
        /// </summary>
        /// <param name="currentBirthDay">DateTime: Timecontext Current BirthDay</param>
        /// <returns>DateTime: Timecontext Next BirthDay</returns>
        DateTime GetNextBirthDayFromCurrent(DateTime currentBirthDay)
        {
            currentBirthDay = currentBirthDay.AddYears(1);
            return currentBirthDay;
        }
    }
}