using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    public class Factory
    {
        public void StateEntry(string filepath, int count)
        {
            List<Entries> states = new List<Entries>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                String[] entries = line.Split(",");
                
                if (entries.Length == 4)
                {
                    Entries newEntry = new Entries();

                    newEntry.State = entries[0];
                    newEntry.Population = entries[1];
                    newEntry.AreaInSqKm = entries[2];
                    newEntry.DensityPerSqKm = entries[3];

                    states.Add(newEntry);
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }
            var info = states;
            var str = JsonConvert.SerializeObject(info,Formatting.Indented);
            Console.WriteLine(str);
        }
        public void StateCodeEntry(string filepath,int count)
        {
            List<Entries> states = new List<Entries>();
            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                String[] entries = line.Split(",");
                if (entries.Length == 4)
                {
                    Entries newEntry = new Entries();

                    newEntry.SrNo = entries[0];
                    newEntry.State = entries[1];
                    newEntry.TIN = entries[2];
                    newEntry.StateCode = entries[3];

                    states.Add(newEntry);
                    count++;
                }
                else
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains Invalid Records");
                }
            }
            var info = states;
            var str = JsonConvert.SerializeObject(info,Formatting.Indented);
            Console.WriteLine(str);
        }
    }
}
