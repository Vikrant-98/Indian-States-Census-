using System;

namespace IndianStatesCensus
{
    public class US_CensusData : ICSV_Builder_USA_State
    {
        Factory factory = new Factory();
        public string StateCensusAnalyzer(string filepath)
        {
            try
            {
                int count = 0;
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is No Such Files");
                }
                Console.WriteLine(factory.US_CensusData(filepath, count, 1));
                //factory.US_CensusData(filepath, count, 1);
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
