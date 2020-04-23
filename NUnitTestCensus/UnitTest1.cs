using NUnit.Framework;
using IndianStatesCensus;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Testcase1_1()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("HAPPY",matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void Testcase1_2()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("There is No Such Files", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt"));
        }
        [Test]
        public void Testcase1_3()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("File Contains invalid records", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void Testcase1_4()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("There is No Such Files", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt"));
        }
        [Test]
        public void Testcase1_5()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("File contains invalid Headers", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void Testcase2_1()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("HAPPY", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
        [Test]
        public void Testcase2_2()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("There is No Such Files", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.txt"));
        }
    }
}