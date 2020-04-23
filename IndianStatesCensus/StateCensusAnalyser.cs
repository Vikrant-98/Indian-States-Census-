using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IndianStatesCensus
{
    public class StateCensusAnalyser
    {
        public string StateCensusAnalyzer(string filepath)
        {
            try
            {
                int count = 0;
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is no Such Files");
                }

                List<Entries> people = new List<Entries>();
                List<string> lines = File.ReadAllLines(filepath).ToList();
                foreach (string line in lines)
                {
                    String[] entries = line.Split(",");
                    if (count == 0 && (entries[0] != "State" || entries[1] != "Population" || entries[2] != "AreaInSqKm" || entries[3] != "DensityPerSqKm"))
                    {
                        throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File contains invalid Headers");
                    }
                    if (entries.Length == 4)
                    {
                        Entries newEntry = new Entries();

                        newEntry.State = entries[0];
                        newEntry.Population = entries[1];
                        newEntry.AreaInSqKm = entries[2];
                        newEntry.DensityPerSqKm = entries[3];

                        people.Add(newEntry);
                        count++;
                    }
                    else
                    {
                        throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File Contains invalid records");
                    }
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
