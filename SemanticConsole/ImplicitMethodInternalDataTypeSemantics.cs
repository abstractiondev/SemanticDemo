using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SemanticConsole
{
    class ImplicitMethodInternalDataTypeSemantics
    {
        object DoSomething(object parameter)
        {
            DateTime d = (DateTime) parameter;
            d = d.AddYears(1);
            return d;
        }
    }
}
