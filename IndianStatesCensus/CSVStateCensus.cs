using System;

namespace IndianStatesCensus
{
    public class CSVStateCensus : CSV_Builder_StateCode
    {
        Factory factory = new Factory();
        public string CSVStatesCensus(string filepath)
        {
            try
            {
                int count = 0;
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is No Such Files");
                }
                factory.StateCodeEntry(filepath,count,1);
                return "HAPPY";
            }
            catch (IndianStatesCensusException message)
            {
                return message.Message;
            }
            catch (IndexOutOfRangeException message)
            {
                return message.Message;
            }
        }
    }
}
