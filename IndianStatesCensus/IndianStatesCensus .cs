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
            CSVStateCensus obj = new CSVStateCensus();
            Console.WriteLine(obj.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
    }
    public class IndianStatesCensusException : Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, INVALID_RECORDS, NO_SUCH_FILE, NO_SUCH_METHOD, INVALID_HEADERS, NO_SUCH_FIELD, OBJECT_CREATION_ISSUE
        }
        public IndianStatesCensusException(ExceptionType type, String message) : base(message)
        {
        }
    }
}
