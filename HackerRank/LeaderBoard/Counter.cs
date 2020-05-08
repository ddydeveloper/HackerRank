using System.Collections.Generic;
using System.Linq;

namespace HackerRank.LeaderBoard
{
    public class Counter
    {
        public static int[] LeaderBoard(int[] scores, int[] alice)
        {
            var rankings = scores
                .Where(x => x > 0)
                .Distinct()
                .OrderByDescending(x => x)
                .ToArray();
            
            var rankingsCount = rankings.Length;

            if (rankingsCount == 0)
                return alice.Select(x => 1).ToArray();

            var result = new int[alice.Length];
            var aliceScoresCount = alice.Length;
            var i = 0;
            var currentPosition = rankingsCount;

            while (i < aliceScoresCount)
            {
                if (currentPosition == 0)
                {
                    result[i] = 1;
                    i++;
                    continue;
                }

                var currentScore = alice[i];
                var currentRank = rankings[currentPosition - 1];

                if (currentScore < currentRank)
                {
                    result[i] = currentPosition + 1;
                    i++;
                    continue;
                }
                
                if (currentScore == currentRank)
                {
                    result[i] = currentPosition;
                    i++;
                    continue;
                }

                currentPosition--;
            }

            return result.ToArray();
        }
    }
}