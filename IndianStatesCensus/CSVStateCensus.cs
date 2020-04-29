using System;

namespace IndianStatesCensus
{
    public class CSVStateCensus : ICSV_Builder_StateCode
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
                Console.WriteLine(factory.StateCodeEntry(filepath,count,1));
                return "";
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
