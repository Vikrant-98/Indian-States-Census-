using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class StateCodeDAO : ICSV_Builder_StateCode
    {
        /// <summary>
        /// Checking for exception by their types 
        /// Passing filepath to factory class
        /// Factory class returns output
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public string CSVStatesCode(string filepath)
        {
            try
            {
                int count = 0;
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is No Such Files");
                }
                //Console.WriteLine(StateCodeEntry(filepath,count,1));                //Return and Print Output
                return StateCodeEntry(filepath, count, 1);
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
        /// <summary>
        /// List creates to store the data and read file path send by India State Census class
        /// Map the data to sort in perticular format
        /// Store the input in array through object
        /// Take India state and sort it in according format like alphabetic order
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public delegate string GetCountFromCSVStates(string filepath, int count, int index);
        public static string StateCodeEntry(string filepath, int count, int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> Map = File.ReadAllLines(filepath).ToList();

            foreach (string line in Map)
            {
                String[] dilimeter = line.Split(",");
                if (count == 0 && (dilimeter[0] != "SrNo" || dilimeter[1] != "State" || dilimeter[2] != "TIN" || dilimeter[3] != "StateCode"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
                if (dilimeter.Length == 4)
                {
                    Entries newEntry = new Entries
                    {
                        SrNo = dilimeter[0],
                        State = dilimeter[1],
                        TIN = dilimeter[2],
                        StateCode = dilimeter[3]
                    };

                    states.Add(newEntry);
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }

            //Console.WriteLine(SortedInfoPopulation(count, index, states));
            //return count.ToString();
            return SortedInfo(count, index, states);
        }
        /// <summary>
        /// Sort in Alphabetic format
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <param name="entries"></param>
        /// <returns></returns>
        public static string SortedInfo(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (info[i].State.CompareTo(info[j].State) > 0)
                    {
                        Swap(info, i, j);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return info[index].State;
        }
        public static void Swap(List<Entries> info, int i, int j)
        {
            var temp = info[1];

            temp = info[i];
            info[i] = info[j];
            info[j] = temp;
        }
    }
}
