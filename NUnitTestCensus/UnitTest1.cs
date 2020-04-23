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
        public void Testcase1()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("HAPPY",matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void Testcase2()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("There is no Such Files", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt"));
        }
        [Test]
        public void Testcase3()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("File Contains invalid records", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void Testcase4()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("There is no Such Files", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt"));
        }
        [Test]
        public void Testcase5()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("File contains invalid Headers", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }

    }
}