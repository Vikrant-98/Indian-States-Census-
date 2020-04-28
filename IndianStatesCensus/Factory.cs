using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class Factory
    {
        public string StateEntry(string filepath, int count, int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> Map = File.ReadAllLines(filepath).ToList();

            foreach (string line in Map)
            {
                String[] entries = line.Split(",");
                if (count == 0 && (entries[0] != "State" || entries[1] != "Population" || entries[2] != "AreaInSqKm" || entries[3] != "DensityPerSqKm"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
                if (entries.Length == 4)
                {
                    Entries newEntry = new Entries
                    {
                        State = entries[0],
                        Population = entries[1],
                        AreaInSqKm = entries[2],
                        DensityPerSqKm = entries[3]
                    };

                    states.Add(newEntry);
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }

            //Console.WriteLine(SortedInfoArea(count, index, states));
            //Console.WriteLine(SortedInfoDensity(count, index, states));
            //Console.WriteLine(SortedInfoPopulation(count, index, states));
            // Console.WriteLine(SortedInfo(count, index, states));

            return SortedInfoDensity(count, index, states);
        }
        public string SortedInfo(int count, int index, List<Entries> entries)
        {
            var info = entries;
            var temp = info[1];
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (info[i].State.CompareTo(info[j].State) > 0)
                    {
                        temp = info[i];
                        info[i] = info[j];
                        info[j] = temp;
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return info[index].State;
        }

        public string SortedInfoPopulation(int count, int index, List<Entries> entries)
        {
            var info = entries;
            var temp = info[1];
            int countStates = 0;
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].Population) < int.Parse(info[j].Population))
                    {
                        temp = info[i];
                        info[i] = info[j];
                        info[j] = temp;
                    }
                    countStates++;
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            Console.WriteLine(countStates);
            String str1 = countStates.ToString();
            return str1;
        }
        public string SortedInfoDensity(int count, int index, List<Entries> entries)
        {
            var info = entries;
            var temp = info[1];
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].DensityPerSqKm) < int.Parse(info[j].DensityPerSqKm))
                    {
                        temp = info[i];
                        info[i] = info[j];
                        info[j] = temp;
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            return str;
        }
        public string SortedInfoArea(int count, int index, List<Entries> entries)
        {
            var info = entries;
            var temp = info[1];
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].AreaInSqKm) < int.Parse(info[j].AreaInSqKm))
                    {
                        temp = info[i];
                        info[i] = info[j];
                        info[j] = temp;
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return str;
        }

        public string StateCodeEntry(string filepath, int count, int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> Map = File.ReadAllLines(filepath).ToList();

            foreach (string line in Map)
            {
                String[] entries = line.Split(",");
                if (count == 0 && (entries[0] != "SrNo" || entries[1] != "State" || entries[2] != "TIN" || entries[3] != "StateCode"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
                if (entries.Length == 4)
                {
                    Entries newEntry = new Entries
                    {
                        SrNo = entries[0],
                        State = entries[1],
                        TIN = entries[2],
                        StateCode = entries[3]
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
            return SortedInfo(count, index, states);
        }
        public string US_CensusData(string filepath, int count, int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> Map = File.ReadAllLines(filepath).ToList();

            foreach (string line in Map)
            {
                String[] entries = line.Split(",");
                if (count == 0 && (entries[0] != "State Id" || entries[1] != "State" || entries[2] != "Population" || entries[3] != "Housing units" || entries[4] != "Total area" || entries[5] != "Water area" || entries[6] != "Land area" || entries[7] != "Population Density"|| entries[8] != "Housing Density"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
                if (entries.Length == 9)
                {
                    Entries newEntry = new Entries
                    {
                        State_Id = entries[0],
                        State = entries[1],
                        Population = entries[2],
                        Housing_units = entries[3],
                        Total_area = entries[4],
                        Water_area = entries[5],
                        Land_area = entries[6],
                        Population_Density = entries[7],
                        Housing_Density = entries[8]
                    };

                    states.Add(newEntry);
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }
            string str = JsonConvert.SerializeObject(states, Formatting.Indented);

            return str;
        }
    }
}
