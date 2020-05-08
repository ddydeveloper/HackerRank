using System;
using System.Collections.Generic;

namespace HackerRank.PlusMinus
{
    public static class Counter
    {
        internal static List<string> plusMinus(int[] arr) {
            var positiveCount = 0;
            var negativeCount = 0;
            var zeroCount = 0;
            var arrCount = arr.Length;

            foreach(var cur in arr)
            {
                if(cur == 0)
                    zeroCount++;
                else if(cur > 0)
                    positiveCount++;
                else
                    negativeCount++;
            }

            var positiveFraction = positiveCount > 0 ? ((decimal)positiveCount / (decimal)arrCount) : 0;
            var negativeFraction = negativeCount > 0 ? ((decimal)negativeCount / (decimal)arrCount) : 0;
            var zeroFraction = zeroCount > 0 ? ((decimal)zeroCount / (decimal)arrCount) : 0;

            return new List<string>
            {
                positiveFraction.ToString("F6"),
                negativeFraction.ToString("F6"),
                zeroFraction.ToString("F6"),
            };
        }
    }
}