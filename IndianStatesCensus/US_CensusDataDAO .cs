using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class US_CensusDataDAO : ICSV_Builder_USA_State
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
                //Console.WriteLine(US_CensusData(filepath, count, 1));                   //Return and Print Output
                return US_CensusData(filepath, count, 1);
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
        /// Store the input in array through object
        /// Map the data to sort in perticular format
        /// Take India state and sort it in according format like alphabetic order
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public delegate string GetUSCSVCount(string filepath, int count, int index);
        public static string US_CensusData(string filepath, int count, int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> Map = File.ReadAllLines(filepath).ToList();

            foreach (string line in Map)
            {
                String[] dilimeter = line.Split(",");
                if (count == 0 && (dilimeter[0] != "State Id" || dilimeter[1] != "State" || dilimeter[2] != "Population" || dilimeter[3] != "Housing units" || dilimeter[4] != "Total area" || dilimeter[5] != "Water area" || dilimeter[6] != "Land area" || dilimeter[7] != "Population Density" || dilimeter[8] != "Housing Density"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
                if (dilimeter.Length == 9)
                {
                    Entries newEntry = new Entries

                    {
                        State_Id = dilimeter[0],
                        State = dilimeter[1],
                        Population = dilimeter[2],
                        Housing_units = dilimeter[3],
                        Total_area = dilimeter[4],
                        Water_area = dilimeter[5],
                        Land_area = dilimeter[6],
                        Population_Density = dilimeter[7],
                        Housing_Density = dilimeter[8]
                    };

                    states.Add(newEntry);                           //Data Entry through Object
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }


            //return SortedInfoPopulationDensity(count, index, states);         // Returns Most Populated state
            //return count.ToString();                                          // Returns number of states
            //return (SortedInfoTotalArea(count, index, states));               // Returns largest area
            return (SortedInfoPopulation(count, index, states));                // Return population info
            return(SortedInfo(count, index, states));                         // Return Ascending order states

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
                        Swap(info, i, j);                           //Swaping Logic
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return info[index].State;
        }
        /// <summary>
        /// Sort in Larget to Smallest as per Polpualtion Density
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <param name="entries"></param>
        /// <returns></returns>
        public static string SortedInfoPopulationDensity(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (double.Parse(info[i].Population_Density) < double.Parse(info[j].Population_Density))
                    {
                        Swap(info, i, j);                               //Swaping Logic
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            //return str;
            return entries[index].State;
        }
        /// <summary>
        /// Sort in Larget to Smallest as per Total Area
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <param name="entries"></param>
        /// <returns></returns>
        public static string SortedInfoTotalArea(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (double.Parse(info[i].Total_area) < double.Parse(info[j].Total_area))
                    {
                        Swap(info, i, j);                           //Swaping Logic
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            //return str;
            return entries[1].State;
        }
        /// <summary>
        /// Sort in Larget to Smallest Population
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <param name="entries"></param>
        /// <returns></returns>
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
                        Swap(info, i, j);                               //Swaping Logic
                        countStates++;
                    }
                }
            }
            //string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            string str = countStates.ToString();
            return str;
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
