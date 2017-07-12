/*using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;*/

namespace LP_2
{
    class TomitaSimpleFabrica
    {
        public static TomitaWrapper Get(string filename)
        {
            TomitaWrapper t = new TomitaWrapper();
            t.ConfigFileName = filename;
            return t;
        }
    }
}