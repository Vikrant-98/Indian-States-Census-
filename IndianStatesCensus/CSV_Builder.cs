
namespace IndianStatesCensus
{
    interface ICSV_Builder_State
    {
        string StateCensusAnalyzer(string filepath);
    }
    interface ICSV_Builder_StateCode
    {
        string CSVStatesCode(string filepath);
    }
    interface ICSV_Builder_USA_State
    {
        string StateCensusAnalyzer(string filepath);
    }
}
