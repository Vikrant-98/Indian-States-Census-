using static IndianStatesCensus.US_CensusDataDAO;
using static IndianStatesCensus.StateCensusAnalyser;
using static IndianStatesCensus.StateCodeDAO;


namespace IndianStatesCensus
{
    public class Factory
    {
        public static StateCensusAnalyser InstanceOfStateCensusAnalyzer()
        {
            return new StateCensusAnalyser();
        }
        public static StateCodeDAO InstanceOfCSVStatesCensus()
        {
            return new StateCodeDAO();
        }
        public static US_CensusDataDAO InstanceOfUSCensus()
        {
            return new US_CensusDataDAO();
        }
        /// <summary>
        ///Method to create object for State Census Data
        /// </summary>
        public static GetCSVCount DelegateofStateCensusAnalyse()
        {
            StateCensusAnalyser csvStateCensus = InstanceOfStateCensusAnalyzer();
            GetCSVCount getCSVCount = new GetCSVCount(StateEntry);
            return getCSVCount;
        }
        /// <summary>
        ///Method to create object for State Code csv
        /// </summary>
        public static GetCountFromCSVStates DelegateofStatecode()
        {
            StateCodeDAO statesCodeCSV = InstanceOfCSVStatesCensus();
            GetCountFromCSVStates referToCSVSates = new GetCountFromCSVStates(StateCodeEntry);
            return referToCSVSates;
        }
        /// <summary>
        ///Method to create object for US census Data
        /// </summary>
        public static GetUSCSVCount DelegateofUSCensusData()
        {
            US_CensusDataDAO csvUSCensus = InstanceOfUSCensus();
            GetUSCSVCount getCSVCount = new GetUSCSVCount(US_CensusData);
            return getCSVCount;
        }
    }
}
