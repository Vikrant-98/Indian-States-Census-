using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

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
                //Console.WriteLine(StateEntry(filepath,count,1));              //Return and Print Output 
                return StateEntry(filepath, count, 1);
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
        public delegate string GetCSVCount(string filepath, int count, int index);
        public static string StateEntry(string filepath, int count, int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> Map = File.ReadAllLines(filepath).ToList();

            foreach (string line in Map)
            {
                String[] dilimeter = line.Split(",");
                if (count == 0 && (dilimeter[0] != "State" || dilimeter[1] != "Population" || dilimeter[2] != "AreaInSqKm" || dilimeter[3] != "DensityPerSqKm"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
                if (dilimeter.Length == 4)
                {
                    Entries newEntry = new Entries
                    {
                        State = dilimeter[0],
                        Population = dilimeter[1],
                        AreaInSqKm = dilimeter[2],
                        DensityPerSqKm = dilimeter[3]
                    };
                    states.Add(newEntry);
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }

            return count.ToString();                                      // Returns number of states
            //return(SortedInfoArea(count, index, states));                   // Return largest area to smallest area
            //return(SortedInfoDensity(count, index, states));              // Return largest Density area
            //return SortedInfoPopulation(count, index, states);            // Return Population Info
            //return(SortedInfo(count, index, states));                     // Return Ascending order states
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
            Loop(count, entries);
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return info[index].State;
        }
        public static string SortedInfoPopulation(int count, int index, List<Entries> entries)
        {
            var info = entries;

            int countStates = 0;
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].Population) < int.Parse(info[j].Population))
                    {
                        Swap(info, i, j);                           //Swaping Logic
                        countStates++;
                    }
                }
            }
            //string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            string str = countStates.ToString();
            return str;
        }
        /// <summary>
        /// Sort in Larget to Smallest as per Density
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <param name="entries"></param>
        /// <returns></returns>
        public static string SortedInfoDensity(int count, int index, List<Entries> entries)
        {
            var info = entries;
            Loop(count, entries);
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            return str;
        }
        /// <summary>
        /// Sort in Larget to Smallest as per US Total Area
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <param name="entries"></param>
        /// <returns></returns>
        public static string SortedInfoArea(int count, int index, List<Entries> entries)
        {
            var info = entries;
            Loop(count, entries);
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return str;
        }
        /// <summary>
        /// Take index and object of to swap the possition of array
        /// </summary>
        /// <param name="count"></param>
        /// <param name="entries"></param>
        public static void Loop(int count, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (info[i].State.CompareTo(info[j].State) > 0)
                    {
                        Swap(info, i, j);                           //Swaping Logic
                    }
                }
            }
        }
        /// <summary>
        /// Logic for swaping the data entry in array
        /// </summary>
        /// <param name="info"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap(List<Entries> info, int i, int j)
        {
            var temp = info[1];

            temp = info[i];
            info[i] = info[j];
            info[j] = temp;
        }
    }
}
