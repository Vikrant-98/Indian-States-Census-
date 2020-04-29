using System;

namespace IndianStatesCensus
{
    class IndianStatesCensus
    {    /// <summary>
         /// Main method read the data from file
         /// </summary>
         /// <param name="args"></param>
        static void Main(string[] args)
        {
            //StateCensusAnalyser states = new StateCensusAnalyser();
            //Console.WriteLine(states.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
            //CSVStateCensus statescode = new CSVStateCensus();
            //Console.WriteLine(statescode.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
            //US_CensusData US_states = new US_CensusData();
            //Console.WriteLine(US_states.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv"));

        }
    }
    public class IndianStatesCensusException : Exception
    {
    /// <summary>
    /// Type of Exceptions
    /// </summary>
        public enum ExceptionType
        {
            INVALID_RECORDS, NO_SUCH_FILE, INVALID_HEADERS, NO_SUCH_FIELD
        }
        public IndianStatesCensusException(ExceptionType type, String message) : base(message)
        {
        }
    }
}
