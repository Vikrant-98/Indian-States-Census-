using System.Collections.Generic;
using Newtonsoft.Json;

namespace IndianStatesCensus
{
    interface ICSV_Builder_State
    {
        string StateCensusAnalyzer(string filepath);

    }
    interface ICSV_Builder_StateCode
    {
        string CSVStatesCensus(string filepath);
    }
    interface ICSV_Builder_USA_State
    {
        string StateCensusAnalyzer(string filepath);

    }
    public class Sort
    {
        public string SortedInfo(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (info[i].State.CompareTo(info[j].State) > 0)
                    {
                        Swap(info, i, j);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return info[index].State;
        }

        public string SortedInfoPopulation(int count, int index, List<Entries> entries)
        {
            var info = entries;

            int countStates = 0;
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].Population) < int.Parse(info[j].Population))
                    {
                        Swap(info, i, j);
                    }
                    countStates++;
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            //Console.WriteLine(countStates);
            //String str1 = countStates.ToString();
            return str;
        }
        public string SortedInfoDensity(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].DensityPerSqKm) < int.Parse(info[j].DensityPerSqKm))
                    {
                        Swap(info, i, j);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            return str;
        }
        public string SortedInfoPopulationDensity(int count, int index, List<Entries> entries)
        {
            var info = entries;
            
            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (double.Parse(info[i].Population_Density) < double.Parse(info[j].Population_Density))
                    {
                        Swap(info, i, j);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            return str;
        }
        public string SortedInfoTotalArea(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (double.Parse(info[i].Total_area) < double.Parse(info[j].Total_area))
                    {
                        Swap(info, i, j);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);
            return str;
        }
        public string SortedInfoArea(int count, int index, List<Entries> entries)
        {
            var info = entries;

            for (int i = 1; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (int.Parse(info[i].AreaInSqKm) < int.Parse(info[j].AreaInSqKm))
                    {
                        Swap(info,i,j);
                    }
                }
            }
            string str = JsonConvert.SerializeObject(entries, Formatting.Indented);

            return str;
        }

        public void Swap(List<Entries> info,int i,int j)
        {
            
            var temp = info[1];

            temp = info[i];
            info[i] = info[j];
            info[j] = temp;

        }

    }
}
