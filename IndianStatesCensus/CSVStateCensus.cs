using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensus
{
    class CSVStateCensus
    {
        /// <summary>
        /// Constructor created to pass CSVState Census 
        /// </summary>
        public CSVStateCensus()
        {
            IndianStatesCensus csvData = new IndianStatesCensus();
            Console.WriteLine(string.Join("", csvData.StateCensus("22", @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv", 1)));
            Console.ReadLine();
        }
    }
}
