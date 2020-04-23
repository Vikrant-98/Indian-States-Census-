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
            StateCensusAnalyser obj = new StateCensusAnalyser();
            Console.WriteLine(obj.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
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
