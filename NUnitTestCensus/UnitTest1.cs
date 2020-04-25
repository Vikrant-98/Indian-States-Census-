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
            Assert.AreEqual("HAPPY", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
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
            Assert.AreEqual("File Contains Invalid Records", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
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
            Assert.AreEqual("File Contains Invalid Headers", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
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
        [Test]
        public void Testcase2_3()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("File Contains Invalid Records", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
        [Test]
        public void Testcase2_4()
        {
            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("There is No Such Files", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.txt"));
        }
        [Test]
        public void Testcase2_5()
        {

            CSVStateCensus matches = new CSVStateCensus();
            Assert.AreEqual("File Contains Invalid Headers", matches.CSVStatesCensus(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv"));
        }
        [Test]
        public void Testcase3()
        {
            Factory factory = new Factory();
            string actual = factory.StateEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv",0, 1);
            Assert.AreEqual("Arunachal Pradesh", actual);
        }
        [Test]
        public void Testcase3_1()
        {
            Factory factory = new Factory();
            string actual = factory.StateEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv", 0, 29);
            Assert.AreEqual("West Bengal", actual);
        }
        [Test]
        public void Testcase4()
        {
            Factory factory = new Factory();
            string actual = factory.StateCodeEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv", 0, 1);
            Assert.AreEqual("Andhra Pradesh", actual);
        }
        [Test]
        public void Testcase4_1()
        {
            Factory factory = new Factory();
            string actual = factory.StateCodeEntry(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCode.csv", 0, 37);
            Assert.AreEqual("West Bengal", actual);
        }
    }
}