using NUnit.Framework;
using IndianStatesCensus;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GiventheStatesWhenAnalyseShouldRecordNumberOfRecordmatches()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("HAPPY", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void GiventheStateCensusCSVFileincorrectReturnscustomException()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("There is No Such Files", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt"));
        }
        [Test]
        public void GiventheStateCensusCSV_FileWhenCorrectbuttypeincorrectReturnscustomException()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("File Contains Invalid Records", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        
        [Test]
        public void GiventheStateCensusCSV_FilewhenCorrectbutcsvheaderincorrectReturnsCustomException()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("File Contains Invalid Headers", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void GiventheStatesCodeWhenAnalyseShouldRecordNumberOfRecordmatches()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("HAPPY", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
        [Test]
        public void Given_the_StateCode_CSV_File_incorrect_Returns_custom_Exception()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("There is No Such Files", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.txt"));
        }
        [Test]
        public void GiventheStateCodeCSVFile_correct_but_type_incorrect_Returns_custom_Exception()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("File Contains Invalid Records", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
        
        [Test]
        public void GiventheStateCodeCSVFile_correctButcsv_header_incorrect_Returns_custom_Exception()
        {

            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("File Contains Invalid Headers", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
        [Test]
        public void Statealphabeticalorder_First()
        {
            Factory factory = new Factory();
            string actual = factory.StateEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv",0, 1);
            Assert.AreEqual("Arunachal Pradesh", actual);
        }
        [Test]
        public void Statealphabeticalorder_Last()
        {
            Factory factory = new Factory();
            string actual = factory.StateEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv", 0, 29);
            Assert.AreEqual("West Bengal", actual);
        }
        [Test]
        public void StateCodeinanalphabeticalorder_First()
        {
            Factory factory = new Factory();
            string actual = factory.StateCodeEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv", 0, 1);
            Assert.AreEqual("Andhra Pradesh", actual);
        }
        [Test]
        public void StateCodeinanalphabeticalorder_Last()
        {
            Factory factory = new Factory();
            string actual = factory.StateCodeEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv", 0, 37);
            Assert.AreEqual("West Bengal", actual);
        }
    }
}