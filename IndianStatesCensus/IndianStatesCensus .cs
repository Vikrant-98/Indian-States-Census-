using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace IndianStatesCensus
{
    public class IndianStatesCensus
    {
        static void Main(string[] args)
        {
            
        }
        /// <summary>
        /// String array created to store the records 
        /// Searching the data entry from given file path
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="filepath"></param>
        /// <param name="positionOfSearchTerm"></param>
        /// <returns></returns>
        public string[] StateCensus(string searchTerm,string filepath,int positionOfSearchTerm)
        {
            positionOfSearchTerm--;
            string[] recordNotFound = { "RecordNotFound" };
            try
            {
                String[] line = System.IO.File.ReadAllLines(filepath);
                for (int i = 0; i < line.Length; i++)
                {
                    String[] entrie = line[i].Split(',');
                    if (Record(searchTerm,entrie,positionOfSearchTerm))
                    {
                        Console.WriteLine("Record Found");
                        return entrie;
                    }
                }
                return recordNotFound;
            }
            catch(Exception ex)
            {
                return recordNotFound;
                throw new ApplicationException("There is no such data : ",ex);
            }
        }
        /// <summary>
        ///  Check weather the records are matching
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="record"></param>
        /// <param name="positionOfSearchTerm"></param>
        /// <returns></returns>
        public bool Record(string searchTerm,string[] record, int positionOfSearchTerm)
        {
            if (record[positionOfSearchTerm].Equals(searchTerm))
            {
                return true;
            }
            return false;
        }
    }
}
