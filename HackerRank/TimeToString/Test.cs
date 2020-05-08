using NUnit.Framework;

namespace HackerRank.TimeToString
{
    public class Test
    {
        [Test]
        public void Test5OClock()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 0), "five o' clock");
        }
        
        [Test]
        public void Test1MinutePast5()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 1), "one minute past five");
        }
        
        [Test]
        public void Test10MinutesPast5()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 10), "ten minutes past five");
        }
        
        [Test]
        public void TestQuarterPast5()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 15), "quarter past five");
        }
        
        [Test]
        public void TestHalfPast5()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 30), "half past five");
        }
        
        [Test]
        public void TestQuarterTo6()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 45), "quarter to six");
        }
        
        [Test]
        public void Test17MinutesTo6()
        {
            Assert.AreEqual(Counter.TimeInWords(5, 47), "thirteen minutes to six");
        }
    }
}