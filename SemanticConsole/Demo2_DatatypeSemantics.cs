using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticConsole
{
    class Demo2_DatatypeSemantics
    {
        DateTime DoSomething(DateTime parameter)
        {
            parameter = parameter.AddYears(1);
            return parameter;
        }
    }
}
