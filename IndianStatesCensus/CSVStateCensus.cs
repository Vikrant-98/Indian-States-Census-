using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IndianStatesCensus
{
    class CSVStateCensus
    {
        public string CSVStatesCensus(string filepath)
        {
            try
            {
                int count = 0;
                string FILEPATH = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
                if (filepath != FILEPATH)
                {
                    throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.NO_SUCH_FILE, "There is no Such Files");
                }

                List<Entries> states = new List<Entries>();
                List<string> lines = File.ReadAllLines(filepath).ToList();

                foreach (string line in lines)
                {
                    String[] entries = line.Split(",");
                    if (count == 0 && (entries[0] != "SrNo" || entries[1] != "State" || entries[2] != "TIN" || entries[3] != "StateCode"))
                    {
                        throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_HEADERS, "File contains invalid Headers");
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
                        throw new IndianStatesCensusException(IndianStatesCensusException.ExceptionType.INVALID_RECORDS, "File contains invalid records");
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
