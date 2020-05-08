using NUnit.Framework;

namespace HackerRank.StringBiggerIsGreater
{
    public class Test
    {
        [Test]
        public void Test_lmno() => Assert.AreEqual(Counter.biggerIsGreater("lmno"), "lmon");
        
        [Test]
        public void Test_dcba() => Assert.AreEqual(Counter.biggerIsGreater("dcba"), "no answer");
        
        [Test]
        public void Test_dcbb() => Assert.AreEqual(Counter.biggerIsGreater("dcbb"), "no answer");
        
        [Test]
        public void Test_abdc() => Assert.AreEqual(Counter.biggerIsGreater("abdc"), "acbd");
        
        [Test]
        public void Test_abcd() => Assert.AreEqual(Counter.biggerIsGreater("abcd"), "abdc");
        
        [Test]
        public void Test_fedcbabcd() => 
            Assert.AreEqual(Counter.biggerIsGreater("fedcbabcd"), "fedcbabdc");
    }
}