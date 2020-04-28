using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    interface CSV_Builder_State
    {
        string StateCensusAnalyzer(string filepath);

    }
    interface CSV_Builder_StateCode
    {
        string CSVStatesCensus(string filepath);
    }

    public class Sort
    {
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


    }
}
