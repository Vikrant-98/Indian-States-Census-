using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IndianStatesCensus
{
    public class Factory
    {
        Sort sort = new Sort();
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

            //return(sort.SortedInfoArea(count, index, states));
            return(sort.SortedInfoDensity(count, index, states));
            //return(sort.SortedInfoPopulation(count, index, states));
            
            //return (sort.SortedInfo(count, index, states));
            
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
            
            return sort.SortedInfo(count, index, states);
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

            
            return(sort.SortedInfoPopulationDensity(count, index, states));
            //return (sort.SortedInfoTotalArea(count, index, states));
            //return(sort.SortedInfo(count, index, states));

        }
    }
}
