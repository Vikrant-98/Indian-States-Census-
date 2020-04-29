using System;

namespace IndianStatesCensus
{
    public class StateCensusAnalyser : ICSV_Builder_State 
    {
        Factory factory = new Factory();
        public string StateCensusAnalyzer(string filepath)
        {
            try
            {
                int count = 0;
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is No Such Files");
                }
                Console.WriteLine(factory.StateEntry(filepath,count,1));
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
