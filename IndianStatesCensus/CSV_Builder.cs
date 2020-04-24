using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensus
{
    interface CSV_Builder_State
    {
        string StateCensusAnalyzer(string filepath);

    }
    interface CSV_Builder_StateCode
    {
        string CSVStatesCensus(string filepath);
    }
}
