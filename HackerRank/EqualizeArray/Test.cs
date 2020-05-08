using System.Runtime.InteropServices;
using HackerRank.EqualizeArray;
using NUnit.Framework;

namespace HackerRank.EqualizeArray
{
    public class Tests
    {
        [Test]
        public void Test_3Steps()
        {
            var arr = new[] {3, 3, 2, 1, 3};
            var stepsToEqualize = Counter.EqualizeArray(arr);
            Assert.True(stepsToEqualize == 2);
        }
        
        [Test]
        public void Test_6Steps()
        {
            var arr = new[] {1, 3, 4, 4, 4, 5, 6, 7, 7};
            var stepsToEqualize = Counter.EqualizeArray(arr);
            Assert.True(stepsToEqualize == 6);
        }
        
        [Test]
        public void Test_7Steps()
        {
            var arr = new[] {1, 3, 4, 4, 4, 5, 6, 7, 7, 7};
            var stepsToEqualize = Counter.EqualizeArray(arr);
            Assert.True(stepsToEqualize == 7);
        }
    }
}