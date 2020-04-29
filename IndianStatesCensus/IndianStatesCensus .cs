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
            StateCensusAnalyser states = new StateCensusAnalyser();
            string IndiaData = states.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv");
            Console.WriteLine(IndiaData);
            CSVStateCensus statescode = new CSVStateCensus();
            Console.WriteLine(statescode.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
            US_CensusData US_states = new US_CensusData();
            string US_Data = US_states.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv");
            Console.WriteLine(US_Data);

            if (IndiaData.CompareTo(US_Data) > 0)
            {
                Console.WriteLine("Population density of India is More then US");
            }
            else
            {
                Console.WriteLine("Population density of US is More then India ");
            }
        }
    }
    public class IndianStatesCensusException : Exception
    {
        public enum ExceptionType
        {
            INVALID_RECORDS, NO_SUCH_FILE, INVALID_HEADERS, NO_SUCH_FIELD
        }
        public IndianStatesCensusException(ExceptionType type, String message) : base(message)
        {
        }
    }
}
