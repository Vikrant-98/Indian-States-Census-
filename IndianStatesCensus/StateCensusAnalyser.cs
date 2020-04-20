using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensus
{
    class StateCensusAnalyser
    {
        /// <summary>
        /// Constructor created to load the State Census Data file
        /// </summary>
        public StateCensusAnalyser()
        {
            IndianStatesCensus states = new IndianStatesCensus();
            StateCensusAnalyser obj = new StateCensusAnalyser();
            Console.WriteLine(string.Join("", states.StateCensus("Maharashta", @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv", 1)));
            Console.ReadLine();
        } 
    }
}
