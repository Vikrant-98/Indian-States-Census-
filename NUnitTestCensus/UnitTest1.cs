using NUnit.Framework;
using IndianStatesCensus;

namespace Tests
{
    public class Tests
    {
        /// <summary>
        /// TC-1.1: Test for checking number of Records
        /// </summary>
        [Test]
        public void GiventheStatesWhenAnalyseShouldRecordNumberOfRecordmatches()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
            Assert.AreEqual("", matches.StateCensusAnalyzer(filepath));
        }
        /// <summary>
        /// TC-1.2:If file incorrect then throw custom exception
        /// </summary>
        [Test]
        public void GiventheStateCensusCSVFileincorrectReturnscustomException()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt" ;
            Assert.AreEqual("There is No Such Files", matches.StateCensusAnalyzer(filepath));
        }
        /// <summary>
        /// TC-1.3:If Record incorrect then throw custom exception
        /// </summary>
        [Test]
        public void GiventheStateCensusCSV_File_type_IncorrectReturn_Exception()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
            Assert.AreEqual("File Contains Invalid Records", matches.StateCensusAnalyzer(filepath));
        }
        /// <summary>
        /// TC-1.4:If Header incorrect then throw custom exception
        /// </summary>
        [Test]
        public void GiventheStateCensusCSV_FilewhenCorrectbutcsvheaderincorrectReturnsCustomException()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
            Assert.AreEqual("File Contains Invalid Headers", matches.StateCensusAnalyzer(filepath));
        }
        /// <summary>
        /// TC-2.1: Test for checking number of Records
        /// </summary>
        [Test]
        public void GiventheStatesCodeWhenAnalyseShouldRecordNumberOfRecordmatches()
        {
            CSVStateCensus matches = new CSVStateCensus();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
            Assert.AreEqual("", matches.CSVStatesCensus(filepath));
        }
        /// <summary>
        /// TC-2.2:If file incorrect then throw custom exception
        /// </summary>
        [Test]
        public void Given_the_StateCode_CSV_File_incorrect_Returns_custom_Exception()
        {
            CSVStateCensus matches = new CSVStateCensus();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.txt";
            Assert.AreEqual("There is No Such Files", matches.CSVStatesCensus(filepath));
        }
        /// <summary>
        /// TC-2.3:If Record incorrect then throw custom exception
        /// </summary>
        [Test]
        public void GiventheStateCodeCSVFile_correct_but_type_incorrect_Returns_custom_Exception()
        {
            CSVStateCensus matches = new CSVStateCensus();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
            Assert.AreEqual("File Contains Invalid Records", matches.CSVStatesCensus(filepath));
        }
        /// <summary>
        /// TC-2.4:If Header incorrect then throw custom exception
        /// </summary>
        [Test]
        public void GiventheStateCodeCSVFile_correctButcsv_header_incorrect_Returns_custom_Exception()
        {

            CSVStateCensus matches = new CSVStateCensus();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
            Assert.AreEqual("File Contains Invalid Headers", matches.CSVStatesCensus(filepath));
        }
        /// <summary>
        /// Arrange stateSencus data in Alphabetical order first state
        /// </summary>
        [Test]
        public void State_Alphabeticalorder_First()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
            string actual = factory.StateEntry(filepath,0, 1);
            Assert.AreEqual("Andhra Pradesh", actual);
        }
        /// <summary>
        /// Arrange StateSencus data in Alphabetical order last state
        /// </summary>
        [Test]
        public void State_Alphabeticalorder_Last()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
            string actual = factory.StateEntry(filepath, 0, 29);
            Assert.AreEqual("West Bengal", actual);
        }
        /// <summary>
        /// Arrange StateCode data in Alphabetical order First state
        /// </summary>
        [Test]
        public void StateCodeinanalphabeticalorder_First()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
            string actual = factory.StateCodeEntry(filepath, 0, 1);
            Assert.AreEqual("Andaman and Nicobar Islands", actual);
        }
        /// <summary>
        /// Arrange StateCode data in Alphabetical order Last state
        /// </summary>
        [Test]
        public void StateCodeiInAnalphAbeticalOrder_Last()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv";
            string actual = factory.StateCodeEntry(filepath, 0, 37);
            Assert.AreEqual("West Bengal", actual);
        }
        /// <summary>
        /// Number of time Record checked Indian Sensus Data
        /// </summary>
        [Test]
        public void PassReportNumberOfStatesSorted()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv";
            string actual = factory.StateEntry(filepath, 0, 37);
            Assert.AreEqual("0", actual);
        }
        /// <summary>
        /// US data of highest population density State
        /// </summary>
        [Test]
        public void Given_Population_Density_Most_US_Populated_States()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv";
            string actual = factory.US_CensusData(filepath, 0, 1);
            Assert.AreEqual("District of Columbia", actual);
        }
        /// <summary>
        /// Arrange US StateSensus data in Alphabetical order First state
        /// </summary>
        [Test]
        public void US_State_in_analphabetical_Order_First()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv";
            string actual = factory.US_CensusData(filepath, 0, 1);
            Assert.AreEqual("Alabama", actual);
        }
        /// <summary>
        /// Arrange US StateSensus data in Alphabetical order Last state
        /// </summary>
        [Test]
        public void US_State_in_analphabetical_Order_Last()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv";
            string actual = factory.US_CensusData(filepath, 0, 51);
            Assert.AreEqual("Wyoming", actual);
        }
        /// <summary>
        /// US data of highest Total Area State
        /// </summary>
        [Test]
        public void US_State_in_TotalArea_Order_First_States()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv";
            string actual = factory.US_CensusData(filepath, 0, 1);
            Assert.AreEqual("Alaska", actual);
        }
        /// <summary>
        /// Number of time Record checked in US Sensus data
        /// </summary>
        [Test]
        public void PassReportNumberOf_US_StatesSorted()
        {
            Factory factory = new Factory();
            string filepath = @"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\USCensusData.csv";
            string actual = factory.US_CensusData(filepath, 0, 37);
            Assert.AreEqual("623", actual);
        }
    }
}