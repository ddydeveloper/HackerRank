using System.Linq;
using NUnit.Framework;

namespace HackerRank.LeaderBoard
{
    public class Test
    {
        [Test]
        public void TestSingle()
        {
            var scores = new int[] {};
            var aliceScores = new[] {10, 20, 30};
            var result = Counter.LeaderBoard(scores, aliceScores);

            Assert.True(result.SequenceEqual(new[] {1, 1, 1}));
        }
        
        [Test]
        public void TestTwoPositions()
        {
            var scores = new[] {20};
            var aliceScores = new[] {10, 20, 30};
            var result = Counter.LeaderBoard(scores, aliceScores);

            Assert.True(result.SequenceEqual(new[] {2, 1, 1}));
        }

        [Test]
        public void TestClimbing()
        {
            var scores = new[] {50, 50, 70, 80, 80, 80, 100};
            var aliceScores = new[] {30, 40, 55, 80, 85, 100, 105};
            var result = Counter.LeaderBoard(scores, aliceScores);

            Assert.True(result.SequenceEqual(new[] {5, 5, 4, 2, 2, 1, 1}));
        }
    }
}