using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IndianStatesCensus
{
    interface States
    {
        string StateCensusAnalyzer(string filepath);
    }

    public class StateCensusAnalyser : States
    {
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
                return "HAPPY";
            }
            catch (IndianStatesCensusException message)
            {
                return message.Message;
            }
            catch (IndexOutOfRangeException message)
            {
                return message.Message;
            }
        }
    }
}
