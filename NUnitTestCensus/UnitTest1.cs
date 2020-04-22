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
        public void Test1()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("HAPPY",matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.csv"));
        }
        [Test]
        public void Test2()
        {
            StateCensusAnalyser matches = new StateCensusAnalyser();
            Assert.AreEqual("HAPPY", matches.StateCensusAnalyzer(@"C:\Users\The Daddy\source\repos\IndianStatesCensus\IndianStatesCensus\StateCensusData.txt"));
        }
    }
}