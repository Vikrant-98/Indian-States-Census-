using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class Factory
    {
        public string StateEntry(string filepath, int count,int index)
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
           // Console.WriteLine(SortedInfo(count, index, states));
            return SortedInfo(count,index,states);
        }
        public string SortedInfo(int count,int index,List<Entries> entries)
        {
            var info = entries;
            var temp = info[1];
            for (int i = 0; i < count; i++)
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
        public string StateCodeEntry(string filepath,int count,int index)
        {
            List<Entries> states = new List<Entries>();
            List<string> lines = File.ReadAllLines(filepath).ToList();
            
            foreach (string line in lines)
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
            //Console.WriteLine(SortedInfo(count, index, states));
            return SortedInfo(count, index, states);
        }
    }
}
