using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                if (count == 0 && (entries[0] != "State" || entries[1] != "Population" || entries[2] != "AreaInSqKm" || entries[3] != "DensityPerSqKm"))
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File Contains Invalid Headers");
                }
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
            foreach (var state in states)
            {
                Console.WriteLine($"{ state.State } { state.Population } { state.AreaInSqKm } { state.DensityPerSqKm }");
            }
        }
        public void StateCodeEntry(string filepath,int count)
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
            foreach (var state in states)
            {
                Console.WriteLine($"{ state.SrNo } { state.State } { state.TIN } { state.StateCode }");
            }
        }
    }
}
