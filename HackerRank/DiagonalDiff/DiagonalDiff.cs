using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace HackerRank
{
    internal static class Counter
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            var linesNumber = arr.Count;
            var forward = new int[linesNumber];
            var backward = new int[linesNumber];

            var i = 0;
            var j = linesNumber - 1;

            while (j >= 0) 
            {
                forward[i] = arr[i][i];
                backward[i] = arr[i][j];
                i++;
                j--;
            }

            var forwardSum = forward.Aggregate(0L, (agg, cur) => agg + cur);
            var backwardSum = backward.Aggregate(0L, (agg, cur) => agg + cur);

            return (int) Math.Abs(forwardSum - backwardSum);
        }
    }
}