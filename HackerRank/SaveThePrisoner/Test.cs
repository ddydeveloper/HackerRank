using NUnit.Framework;

namespace HackerRank.SaveThePrisoner
{
    public class Test
    {
        [Test]
        public void Test_NoPrisoners()
        {
            Assert.True(Counter.PrisonerToWarnNumber(0, 2, 1) == -1);
        }
        
        [Test]
        public void Test_NoSweets()
        {
            Assert.True(Counter.PrisonerToWarnNumber(2, 0, 10) == -1);
        }
        
        [Test]
        public void Test_2Prisoner()
        {
            Assert.True(Counter.PrisonerToWarnNumber(5, 2, 1) == 2);
        }
        
        [Test]
        public void Test_3Prisoner()
        {
            Assert.True(Counter.PrisonerToWarnNumber(5, 2, 2) == 3);
        }
        
        [Test]
        public void Test_6Prisoner()
        {
            Assert.True(Counter.PrisonerToWarnNumber(7, 19, 2) == 6);
        }
    }
}