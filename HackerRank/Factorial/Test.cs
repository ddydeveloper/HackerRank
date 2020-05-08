using NUnit.Framework;

namespace HackerRank.Factorial
{
    public class Tests
    {
        [Test]
        public void Test2()
        {
            var result = Counter.extraLongFactorials(3);
            Assert.True(result == "6");
        }

        [Test]
        public void Test10()
        {
            var result = Counter.extraLongFactorials(10);
            Assert.True(result == "3628800");
        }
        
        [Test]
        public void Test25()
        {
            var result = Counter.extraLongFactorials(25);
            Assert.True(result == "15511210043330985984000000");
        }
    }
}