using System;

namespace IndianStatesCensus
{
    public class StateCensusAnalyser : ICSV_Builder_State 
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
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is No Such Files");
                }
                Factory factory = new Factory();
                Console.WriteLine(factory.StateEntry(filepath,count,1));              //Return and Print Output 
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
