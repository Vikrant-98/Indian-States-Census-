using System;

namespace IndianStatesCensus
{
    public class US_CensusData : ICSV_Builder_USA_State
    {
        /// <summary>
        /// Checking for exception by their types 
        /// Passing filepath to factory class
        /// Factory class returns output
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
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
                Factory factory = new Factory();
                Console.WriteLine(factory.US_CensusData(filepath, count, 1));                   //Return and Print Output
                return "";
            }
            catch (IndianStatesCensusException message)
            {
                return message.Message;                                              //Invalid Valid Exception
            }
            catch (IndexOutOfRangeException message)
            {
                return message.Message;                                              //Out of range Exception
            }
        }
    }
}
